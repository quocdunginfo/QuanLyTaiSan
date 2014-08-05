﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="t.aspx.cs" Inherits="WebQLPH.t" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" media="screen" href="http://silviomoreto.github.io/bootstrap-select/stylesheets/stylesheet.css" />
    <link href="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.1/css/bootstrap-combined.min.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" media="screen" href="http://silviomoreto.github.io/bootstrap-select/stylesheets/bootstrap-select.css" />
    <link rel="stylesheet" type="text/css" media="screen" href="http://silviomoreto.github.io/bootstrap-select/stylesheets/scrollYou.css" />
</head>
<body>
    <select class="selectpicker">
        <option>Mustard</option>
        <option>Ketchup</option>
        <option>Relish</option>
    </select>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="http://silviomoreto.github.io/bootstrap-select/javascripts/prettify.js"></script>
    <script src="http://netdna.bootstrapcdn.com/twitter-bootstrap/2.3.1/js/bootstrap.min.js"></script>
    <script src="http://silviomoreto.github.io/bootstrap-select/javascripts/bootstrap-select.js"></script>
    <script src="http://silviomoreto.github.io/bootstrap-select/javascripts/jquery.mousewheel.js"></script>
    <script src="http://silviomoreto.github.io/bootstrap-select/javascripts/scrollYou.js"></script>
    <script type="text/javascript">
        window.onload = function () {
            $('.selectpicker').selectpicker();
        };
    </script>
</body>
</html>
