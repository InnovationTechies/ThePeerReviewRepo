﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using PeerReviewSystem.Models;

namespace PeerReviewSystem
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            //Updates Database on change
            Database.SetInitializer<ReviewDbContext>(new ReviewDDContextSeeder());
            //DropCreateDatabaseIfModelChanges<ReviewDbContext>();

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }
    }
}