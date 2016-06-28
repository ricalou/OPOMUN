﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
	Public Sub RegisterRoutes(ByVal routes As RouteCollection)
		routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
		routes.LowercaseUrls = True

		routes.MapRoute(
			name:="Landing Default",
			url:="{controller}/{action}/{id}",
			defaults:=New With {.controller = "home", .action = "landing", .id = UrlParameter.Optional}
		)

		routes.MapRoute(
			name:="Index Fallback",
			url:="{controller}/{action}/{id}",
			defaults:=New With {.controller = "home", .action = "index", .id = UrlParameter.Optional}
		)
	End Sub
End Module