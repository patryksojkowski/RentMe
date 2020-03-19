// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace RentMe.Controllers
{
    public partial class RentalsController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public RentalsController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RentalsController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult SearchResult()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SearchResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult RentDetails()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RentDetails);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ClientDetails()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ClientDetails);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult New()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.New);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public RentalsController Actions { get { return MVC.Rentals; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Rentals";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Rentals";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string SearchResult = "SearchResult";
            public readonly string RentDetails = "RentDetails";
            public readonly string ClientDetails = "ClientDetails";
            public readonly string New = "New";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string SearchResult = "SearchResult";
            public const string RentDetails = "RentDetails";
            public const string ClientDetails = "ClientDetails";
            public const string New = "New";
        }


        static readonly ActionParamsClass_SearchResult s_params_SearchResult = new ActionParamsClass_SearchResult();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SearchResult SearchResultParams { get { return s_params_SearchResult; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SearchResult
        {
            public readonly string viewModel = "viewModel";
        }
        static readonly ActionParamsClass_RentDetails s_params_RentDetails = new ActionParamsClass_RentDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RentDetails RentDetailsParams { get { return s_params_RentDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RentDetails
        {
            public readonly string pickupDate = "pickupDate";
            public readonly string returnDate = "returnDate";
            public readonly string carGroupId = "carGroupId";
        }
        static readonly ActionParamsClass_ClientDetails s_params_ClientDetails = new ActionParamsClass_ClientDetails();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ClientDetails ClientDetailsParams { get { return s_params_ClientDetails; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ClientDetails
        {
            public readonly string pickupDate = "pickupDate";
            public readonly string returnDate = "returnDate";
            public readonly string carGroupId = "carGroupId";
        }
        static readonly ActionParamsClass_New s_params_New = new ActionParamsClass_New();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_New NewParams { get { return s_params_New; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_New
        {
            public readonly string viewModel = "viewModel";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string ClientDetails = "ClientDetails";
                public readonly string RentDetails = "RentDetails";
                public readonly string SearchResult = "SearchResult";
                public readonly string Successful = "Successful";
            }
            public readonly string ClientDetails = "~/Views/Rentals/ClientDetails.cshtml";
            public readonly string RentDetails = "~/Views/Rentals/RentDetails.cshtml";
            public readonly string SearchResult = "~/Views/Rentals/SearchResult.cshtml";
            public readonly string Successful = "~/Views/Rentals/Successful.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_RentalsController : RentMe.Controllers.RentalsController
    {
        public T4MVC_RentalsController() : base(Dummy.Instance) { }

        [NonAction]
        partial void SearchResultOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, RentMe.ViewModels.SearchViewModel viewModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult SearchResult(RentMe.ViewModels.SearchViewModel viewModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SearchResult);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewModel", viewModel);
            SearchResultOverride(callInfo, viewModel);
            return callInfo;
        }

        [NonAction]
        partial void RentDetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.DateTime pickupDate, System.DateTime returnDate, int carGroupId);

        [NonAction]
        public override System.Web.Mvc.ActionResult RentDetails(System.DateTime pickupDate, System.DateTime returnDate, int carGroupId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RentDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pickupDate", pickupDate);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnDate", returnDate);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "carGroupId", carGroupId);
            RentDetailsOverride(callInfo, pickupDate, returnDate, carGroupId);
            return callInfo;
        }

        [NonAction]
        partial void ClientDetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.DateTime pickupDate, System.DateTime returnDate, int carGroupId);

        [NonAction]
        public override System.Web.Mvc.ActionResult ClientDetails(System.DateTime pickupDate, System.DateTime returnDate, int carGroupId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ClientDetails);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "pickupDate", pickupDate);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnDate", returnDate);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "carGroupId", carGroupId);
            ClientDetailsOverride(callInfo, pickupDate, returnDate, carGroupId);
            return callInfo;
        }

        [NonAction]
        partial void NewOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, RentMe.ViewModels.RentClientDetailsViewModel viewModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult New(RentMe.ViewModels.RentClientDetailsViewModel viewModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.New);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewModel", viewModel);
            NewOverride(callInfo, viewModel);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
