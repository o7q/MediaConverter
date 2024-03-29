function bodyInit()
{
    var VERSION = "v1.1.1.0";

    document.getElementById("downloadID").href = "https://github.com/o7q/MediaConverter/releases/download/" + VERSION + "/MediaConverter." + VERSION + ".zip";
    document.getElementById("downloadID").innerHTML = "Download " + VERSION;
}