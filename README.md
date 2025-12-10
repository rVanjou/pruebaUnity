# pruebaUnity

Repositorio de prueba para Unity con estructura mínima (*assets*, *packages*, *ProjectSettings*). Contiene la configuración básica de proyecto y ejemplos para abrir y experimentar con Unity. La licencia aplicada es **CC0-1.0** (dominio público).

---

## Tabla de contenidos

* [Características](#características)
* [Requisitos](#requisitos)
* [Abrir el proyecto](#abrir-el-proyecto)
* [Estructura del repositorio](#estructura-del-repositorio)
* [Licencia](#licencia)

---

## Características

* Proyecto Unity de ejemplo con la estructura mínima necesaria para control de versiones: `Assets`, `Packages`, `ProjectSettings`.
* `.gitignore` y archivos de configuración incluidos.
* Licencia pública (CC0-1.0) incluida para reutilización/experimentación libre.

---

## Requisitos

* Unity Hub y el Editor Unity (la versión recomendada está indicada en `ProjectSettings/ProjectVersion.txt`).
* Git (para clonar el repositorio).

---

## Abrir el proyecto

1. Clona el repositorio:

   ```bash
   git clone https://github.com/rVanjou/pruebaUnity.git
   cd pruebaUnity
   ```

2. Comprueba la versión de Unity requerida en `ProjectSettings/ProjectVersion.txt`.

3. Abre Unity Hub → *Open / Add *→ selecciona la carpeta raíz del repositorio.

4. Si la versión del Editor no está instalada, instálala desde Unity Hub.

---

## Estructura del repositorio

```
pruebaUnity/
├─ Assets/               # *Assets* del proyecto (escenas, *scripts*, *prefabs*, etc.)
├─ Packages/             # Manifiesto de paquetes (*manifest.json*)
├─ ProjectSettings/      # Ajustes del proyecto
├─ .gitignore
├─ LICENSE (CC0-1.0)
```

* `Assets/` — contenido del proyecto administrado por Unity.
* `Packages/` — gestión de dependencias.
* `ProjectSettings/ProjectVersion.txt` — versión del Editor usada.

## Licencia

Publicación bajo **CC0-1.0**.
