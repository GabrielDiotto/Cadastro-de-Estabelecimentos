using AutoMapper;
using CRUD.Application.Interface;
using CRUD.Domain.Entities;
using CRUD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CRUD.MVC.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        private readonly ICategoriaAppService _categoriaApp;

        public CategoriaController(ICategoriaAppService categoriaApp)
        {
            _categoriaApp = categoriaApp;
        }

        // GET: Categoria
        public ActionResult Index()
        {
            var categoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaApp.GetAll());
            return View(categoriaViewModel);
        }

        //public ActionResult Especiais()
        //{
        //    var categoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaApp.ObterCategoriasEspeciais());

        //    return View(categoriaViewModel);
        //}

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

            return View(categoriaViewModel);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                _categoriaApp.Add(categoriaDomain);

                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

            return View(categoriaViewModel);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                _categoriaApp.Update(categoriaDomain);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

            return View(categoriaViewModel);
        }

        // POST: Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var categoria = _categoriaApp.GetById(id);
            _categoriaApp.Remove(categoria);

            return RedirectToAction("Index");
        }
    }
}