using System.Web.Mvc;
using AutoMapper;
using CRUD.Application.Interface;
using CRUD.Domain.Entities;
using CRUD.MVC.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace CRUD.MVC.Controllers
{
    public class EstabelecimentoController : Controller
    {
        // GET: Estabelecimento
        private readonly IEstabelecimentoAppService _estabelecimentoApp;
        private readonly ICategoriaAppService _categoriaApp;

        public EstabelecimentoController(IEstabelecimentoAppService estabelecimentoApp, ICategoriaAppService categoriaApp)
        {
            _estabelecimentoApp = estabelecimentoApp;
            _categoriaApp = categoriaApp;
        }

        // GET: Categoria
        public ActionResult Index()
        {
            var estabelecimentoViewModel = Mapper.Map<IEnumerable<Estabelecimento>, IEnumerable<EstabelecimentoViewModel>>(_estabelecimentoApp.GetAll());

            return View(estabelecimentoViewModel);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var estabelecimento = _estabelecimentoApp.GetById(id);
            var estabelecimentoViewModel = Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento);

            return View(estabelecimentoViewModel);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome");
            var model = new EstabelecimentoViewModel();
            return View(model);
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstabelecimentoViewModel estabelecimento)
        {
            var estabelecimentoDomain = Mapper.Map<EstabelecimentoViewModel, Estabelecimento>(estabelecimento);
            var categoriaVinculada = _categoriaApp.ObterCategoria(estabelecimento.CategoriaId);
            
            estabelecimentoDomain.VinculaCategoria(categoriaVinculada);
            estabelecimento.Result = estabelecimentoDomain.Validate();
            
            if (estabelecimento.Result.Count() == 0)
            {
                _estabelecimentoApp.Add(estabelecimentoDomain);
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome", estabelecimento.CategoriaId);

            return View(estabelecimento);
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var estabelecimento = _estabelecimentoApp.GetById(id);
            var estabelecimentoViewModel = Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento);

            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome", estabelecimentoViewModel.CategoriaId);

            return View(estabelecimentoViewModel);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstabelecimentoViewModel estabelecimento)
        {
            if (ModelState.IsValid)
            {
                var estabelecimentoDomain = Mapper.Map<EstabelecimentoViewModel, Estabelecimento>(estabelecimento);
                _estabelecimentoApp.Update(estabelecimentoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome", estabelecimento.CategoriaId);
            return View(estabelecimento);
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            var estabelecimento = _estabelecimentoApp.GetById(id);
            var estabelecimentoViewModel = Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento);

            return View(estabelecimentoViewModel);
        }

        // POST: Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var estabelecimento = _estabelecimentoApp.GetById(id);
            _estabelecimentoApp.Remove(estabelecimento);

            return RedirectToAction("Index");
        }
    }
}