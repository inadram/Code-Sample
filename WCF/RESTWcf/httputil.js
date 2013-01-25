if (WScript.Arguments.length < 2) 
{
   WScript.echo("HTTP POST/PUT Utility\n");
   WScript.echo("usage: httputil method uri file");
   WScript.Quit(1);
}
var method = WScript.Arguments.Item(0);
var uri = WScript.Arguments.Item(1);

req = new ActiveXObject("MSXML2.XMLHTTP");
req.Open(method, uri, false);
req.setRequestHeader("Content-Type", "text/xml");

if (WScript.Arguments.length == 2)
{
	req.Send();
	WScript.echo(req.responseText);
}
else if (WScript.Arguments.length == 3)
{
	var xmlfile = WScript.Arguments.Item(2);
	var fso = new ActiveXObject("Scripting.FileSystemObject");
	var file = fso.OpenTextFile(xmlfile, 1, false);
	req.Send(file.ReadAll());
	file.Close();
	WScript.echo(req.responseText);
}