using ElevenNote.Models.CategoryModels;
using ElevenNote.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote.WebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        private CategoryService _categoryService = new CategoryService();

        public IHttpActionResult Post(CategoryCreate category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_categoryService.CreateCategory(category))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Get()
        {
            var categories = _categoryService.GetCategories();
            return Ok(categories);
        }

        public IHttpActionResult Get(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            return Ok(category);
        }

        public IHttpActionResult Put(CategoryEdit category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!_categoryService.UpdateCategory(category))
            {
                return InternalServerError();
            }

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {

            if (!_categoryService.DeleteCategory(id))
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}
