using NumberToWordConverter.Entities;
using NumberToWordConverter.Framework.Interface;
using NumberToWordConverter.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumberToWordConverter.Controllers
{
    public class NumberToWordController : Controller
    {
        readonly IConverterRepository _converterRepository;
        readonly ILogger _logger;

        public NumberToWordController(ILogger logger, IConverterRepository converterRepository)
        {
            _logger = logger;
            _converterRepository = converterRepository;
        }
        // GET: NumberToWord
        public ActionResult NumberToWord()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult NumberToWordConverter(InputModel input)
        {
            _logger.WriteDebug("N2WController - Index: Method Started");
            if (ModelState.IsValid && input.Number >= (decimal)0.01 && input.Number <= (decimal)999999999999999.99)
            {
                _logger.WriteDebug("N2WController - Index: Convert input in service");
                ViewBag.Result = _converterRepository.ConvertNumberToWord(input.Number.ToString());
                _logger.WriteDebug("N2WController - Index: Conversion Successful");
            }
            return View("NumberToWord");
        }
    }
}