using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AngularLearningController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PropDisplayModel> GetObservablePromise()
        {
           List<PropDisplayModel> prop = new List<PropDisplayModel>();

            //Observabels
            PropDisplayModel observable = new PropDisplayModel();
            observable.Name = "Observables";
            observable.Description = new List<string>()
            {
                "Emit multiple values over a period of time.",
                "Are lazy: they’re not executed until we subscribe to them using the subscribe() method.",
                "Subscriptions that are cancellable using the unsubscribe() method, which stops the listener from receiving further values.",
                "Provide the map for forEach, filter, reduce, retry, and retryWhen operators.",
                "Deliver errors to the subscribers.",
                "help us work with asynchronous functionality in JavaScript",
                "An observable is like a function, subscribing to it invokes the action.",
                "Observables are not executed until a consumer subscribes."
            };
            prop.Add(observable);
            //Promises
            PropDisplayModel promises = new PropDisplayModel();
            promises.Name = "Promises";
            promises.Description = new List<string>()
            {
                "Emit Single values over a time.",
                "Are not lazy: execute immediately after creation.",
                "Are not cancellable.",
                "Don’t provide any operations.",
                "Push errors to the child promises.",
                "help us work with asynchronous functionality in JavaScript"
            };
            prop.Add(promises);
            return prop;
        }
    }
}
