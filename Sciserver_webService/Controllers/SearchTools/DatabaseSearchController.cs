﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Sciserver_webService.ExceptionFilter;
using Sciserver_webService.UseCasjobs;
using net.ivoa.VOTable;
using Sciserver_webService.Common;
using SciServer.Logging;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using Sciserver_webService.Models;

namespace Sciserver_webService.Controllers
{
    public class DatabaseSearchController : ApiController
    {
        [ExceptionHandleAttribute]
        public IHttpActionResult get()
        {
            ProcessRequest request = new ProcessRequest();
            //return request.runquery(this, KeyWords.sqlSearchQuery, KeyWords.sqlSearchQuery, "Simple SQL Search Tool.");
            return request.runquery(this, KeyWords.databaseSearchQuery, KeyWords.databaseSearchQuery, "SkyserverWS.SearchTools.DatabaseSearch");
        }
        [ExceptionHandleAttribute]
        public IHttpActionResult post()
        {
            ProcessRequest request = new ProcessRequest();
            //return request.runquery(this, KeyWords.sqlSearchQuery, KeyWords.sqlSearchQuery, "Simple SQL Search Tool.");
            return request.runquery(this, KeyWords.databaseSearchQuery, KeyWords.databaseSearchQuery, "SkyserverWS.SearchTools.DatabaseSearch");
        }
    }
}