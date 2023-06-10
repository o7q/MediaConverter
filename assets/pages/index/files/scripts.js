function bodyInit()
{
    var ver = "v1.0.0.0";

    document.getElementById("downloadID").href = "https://github.com/o7q/MediaConverter/releases/download/" + ver + "/MediaConverter." + ver + ".zip";
    document.getElementById("downloadID").innerHTML = "Download " + ver;
}