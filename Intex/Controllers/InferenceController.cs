using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using Intex.Models;

namespace Intex.Controllers
{
    
    public class InferenceController : Controller
    {
        private InferenceSession _session;

        public InferenceController(InferenceSession session)
        {
            _session = session;
        }
        [HttpGet]
        public IActionResult Score()
        {
            var prediction = new Prediction { PredictedValue = 0 };
            ViewBag.Prediction = prediction;
            return View();
        }

        [HttpPost]

        public IActionResult Score(CrashModel data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<float> score = result.First().AsTensor<float>();
            var prediction = new Prediction { PredictedValue = score.Last()};
            result.Dispose();
            ViewBag.Prediction = prediction;
            return View(data);
        }
    }
}