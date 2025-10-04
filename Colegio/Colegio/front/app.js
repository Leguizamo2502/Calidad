// ============ Config ============
const apiBase = "https://localhost:7178/api"; // sin cambios

// ============ Infra básica ============
const qs  = (sel, root=document) => root.querySelector(sel);
const qsa = (sel, root=document) => Array.from(root.querySelectorAll(sel));

const Toast = (() => {
  const el = qs("#toast");
  const show = (msg, type="ok") => {
    el.textContent = msg;
    el.className = `toast toast--${type === "ok" ? "ok" : "err"}`;
    el.hidden = false;
    setTimeout(() => (el.hidden = true), 2600);
  };
  return { ok: (m)=>show(m,"ok"), err: (m)=>show(m,"err") };
})();

const Backdrop = (() => {
  const el = qs("#backdrop");
  return {
    show: () => (el.hidden = false),
    hide: () => (el.hidden = true),
  };
})();

class ApiClient {
  constructor(base){ this.base = base; }
  async get(path, signal){
    const res = await fetch(`${this.base}${path}`, { signal });
    if(!res.ok) throw await this.#toError(res);
    return res.json();
  }
  async post(path, body){
    const res = await fetch(`${this.base}${path}`, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(body),
    });
    if(!res.ok) throw await this.#toError(res);
    if (res.status === 204) return null;
    const ct = res.headers.get("content-type") || "";
    return ct.includes("application/json") ? res.json() : null;
  }
  async #toError(res){
    let detail = "";
    try{ detail = (await res.json())?.message || ""; } catch {}
    const err = new Error(detail || `HTTP ${res.status}`);
    err.status = res.status;
    return err;
  }
}

const api = new ApiClient(apiBase);

// ============ Estado en memoria ============
const State = {
  colegios: [],
  cursos:   [],
  salones:  [],
};

// ============ Render helpers ============
const renderEmpty = (name, isEmpty) => {
  const empty = qs(`[data-empty="${name}"]`);
  if(!empty) return;
  empty.hidden = !isEmpty;
};

const renderTable = (name, rows) => {
  const tbody = qs(`table[data-table="${name}"] tbody`);
  const table = qs(`table[data-table="${name}"]`);
  tbody.innerHTML = rows.join("");
  const isEmpty = tbody.children.length === 0;
  table.hidden = isEmpty && name === "distribucion"; // solo distribución se esconde
  renderEmpty(name, isEmpty);
};

const optionize = (items, getValue, getLabel) =>
  items.map(it => `<option value="${getValue(it)}">${getLabel(it)}</option>`).join("");

// ============ Carga inicial y actualización ============
let aborter = null;
async function loadAll(){
  aborter?.abort();
  aborter = new AbortController();
  const { signal } = aborter;

  try{
    qs("main").setAttribute("aria-busy","true");
    Backdrop.show();

    const [colegios, cursos, salones] = await Promise.all([
      api.get("/Colegio", signal),
      api.get("/Cursos", signal),
      api.get("/Salones", signal),
    ]);

    State.colegios = colegios ?? [];
    State.cursos   = cursos ?? [];
    State.salones  = salones ?? [];

    // Cohesión de selects dependientes
    const colegioOpts = `<option value="">Seleccione un colegio</option>` +
      optionize(State.colegios, x => x.id, x => x.name);
    qsa('select[data-select="colegio"]').forEach(sel => sel.innerHTML = colegioOpts);

    const cursoOpts = `<option value="">Seleccione un curso</option>` +
      optionize(State.cursos, x => x.id, x => x.name);
    qsa('select[data-select="curso"]').forEach(sel => sel.innerHTML = cursoOpts);

    // Tablas
    renderTable("colegios", State.colegios.map(c => `
      <tr>
        <td>${escapeHtml(c.name)}</td>
        <td>${escapeHtml(c.address)}</td>
        <td>${escapeHtml(c.phone)}</td>
      </tr>
    `));

    renderTable("cursos", State.cursos.map(c => `
      <tr>
        <td>${escapeHtml(c.name)}</td>
        <td>${escapeHtml(c.description)}</td>
        <td>${escapeHtml(resolveColegioName(c.colegioId))}</td>
      </tr>
    `));

    renderTable("salones", State.salones.map(s => `
      <tr>
        <td>${escapeHtml(s.name)}</td>
        <td>${escapeHtml(resolveCursoName(s.cursoId))}</td>
        <td>${Number.isFinite(s.amount) ? s.amount : "-"}</td>
      </tr>
    `));

  }catch(err){
    console.error(err);
    Toast.err("No se pudo cargar información inicial.");
  }finally{
    qs("main").removeAttribute("aria-busy");
    Backdrop.hide();
  }
}

function resolveColegioName(id){
  return State.colegios.find(x => x.id === id)?.name ?? `#${id}`;
}
function resolveCursoName(id){
  return State.cursos.find(x => x.id === id)?.name ?? `#${id}`;
}

// ============ Forms ============
function getFormData(form){
  const fd = new FormData(form);
  // Convierte strings numéricas a number cuando corresponda
  const obj = {};
  for(const [k,v] of fd.entries()){
    if (/Id$/.test(k) || k === "cantidad") {
      const n = Number(v);
      obj[k] = Number.isFinite(n) ? n : null;
    } else {
      obj[k] = typeof v === "string" ? v.trim() : v;
    }
  }
  return obj;
}

function resetDistribucionUI(){
  const table = qs('table[data-table="distribucion"]');
  const tbody = table.querySelector("tbody");
  tbody.innerHTML = "";
  table.hidden = true;
  renderEmpty("distribucion", true);
}

// Colegio
qs('form[data-form="colegio"]').addEventListener("submit", async (e) => {
  e.preventDefault();
  const form = e.currentTarget;
  const data = getFormData(form);

  if (data.password?.length < 6) {
    Toast.err("La clave debe tener al menos 6 caracteres.");
    return;
  }

  try{
    form.setAttribute("aria-busy","true");
    await api.post("/Colegio", data);
    Toast.ok("Colegio creado.");
    form.reset();
    await loadAll();
  }catch(err){
    console.error(err);
    Toast.err(err?.message || "Error al crear colegio.");
  }finally{
    form.removeAttribute("aria-busy");
  }
});

// Curso
qs('form[data-form="curso"]').addEventListener("submit", async (e) => {
  e.preventDefault();
  const form = e.currentTarget;
  const data = getFormData(form);

  if(!data.colegioId){
    Toast.err("Seleccione un colegio.");
    return;
  }

  try{
    form.setAttribute("aria-busy","true");
    await api.post("/Cursos", data);
    Toast.ok("Curso creado.");
    form.reset();
    await loadAll();
  }catch(err){
    console.error(err);
    Toast.err(err?.message || "Error al crear curso.");
  }finally{
    form.removeAttribute("aria-busy");
  }
});

// Salón
qs('form[data-form="salon"]').addEventListener("submit", async (e) => {
  e.preventDefault();
  const form = e.currentTarget;
  const data = getFormData(form);

  if(!data.cursoId){
    Toast.err("Seleccione un curso.");
    return;
  }

  try{
    form.setAttribute("aria-busy","true");
    await api.post("/Salones", data);
    Toast.ok("Salón creado.");
    form.reset();
    await loadAll();
  }catch(err){
    console.error(err);
    Toast.err(err?.message || "Error al crear salón.");
  }finally{
    form.removeAttribute("aria-busy");
  }
});

// Distribución
qs('form[data-form="distribucion"]').addEventListener("submit", async (e) => {
  e.preventDefault();
  const form = e.currentTarget;
  const { colegioId, cantidad } = getFormData(form);

  if(!colegioId){ Toast.err("Seleccione un colegio."); return; }
  if(!cantidad || cantidad < 1){ Toast.err("Ingrese una cantidad válida."); return; }

  try{
    form.setAttribute("aria-busy","true");
    const data = await api.get(`/Distribucion/${colegioId}/distribuir/${cantidad}`);
    const rows = (data ?? []).map(d => `
      <tr>
        <td>${escapeHtml(d.cursoName)}</td>
        <td>${escapeHtml(d.salonName)}</td>
        <td>${Number.isFinite(d.cantidadAsignada) ? d.cantidadAsignada : "-"}</td>
      </tr>
    `);
    renderTable("distribucion", rows);
    qs('table[data-table="distribucion"]').hidden = rows.length === 0;
    renderEmpty("distribucion", rows.length === 0);
    if(rows.length === 0) Toast.ok("No hubo asignaciones.");
  }catch(err){
    console.error(err);
    resetDistribucionUI();
    Toast.err(err?.message || "Error en distribución.");
  }finally{
    form.removeAttribute("aria-busy");
  }
});

qsa('form[data-form]').forEach(f => {
  f.addEventListener("reset", () => {
    if (f.dataset.form === "distribucion") resetDistribucionUI();
  });
});

// ============ Tabs ============
qsa(".tab").forEach(btn => {
  btn.addEventListener("click", () => {
    qsa(".tab").forEach(b => b.classList.remove("is-active"));
    qsa(".panel").forEach(p => p.classList.remove("is-active"));
    btn.classList.add("is-active");
    const target = btn.getAttribute("data-tab-target");
    qs(target).classList.add("is-active");
  });
});

// ============ Util ============
function escapeHtml(str){
  if (typeof str !== "string") return str ?? "";
  return str.replace(/[&<>"']/g, m => ({
    "&":"&amp;","<":"&lt;",">":"&gt;",'"':"&quot;","'":"&#39;"
  }[m]));
}

// ============ Init ============
loadAll();
