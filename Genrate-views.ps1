$controllers = @{
    "Home"        = "Index"
    "Quality"     = "Index,Procedure,Instruction,P1P2,P3,Customer,Lab"
    "IT"          = "Index,Procedures,Forms,Telephonie,Voip,Mobile"
    "Engineering" = "Index,Procedures,Normes,Fiat,BMW"
    "TD"          = "Index,Procedures,Instructions,TPME,TPMEP1,TPMEP2,TPMEP3"
    "RH"          = "Index,Documents,Procedures,Instructions,JobDescription,SupplyChain,Fiat,Organigramme,Policy"
    "Logistic"    = "Index,Procedures,Instructions"
    "Finance"     = "Index,Procedures,Instructions"
    "Prod"        = "P1P2,P3"
    "SQA"         = "Index"
    "MPPS"        = "Index"
    "Instructions"= "Coupe"
    "EHS"         = "Index,Procedures,Instructions,Manual,Policy"
    "Project"     = "Launch"
    "Purchasing"  = "Index"
}

foreach ($ctrl in $controllers.Keys) {
    $path = "Views\$ctrl"
    if (!(Test-Path $path)) {
        New-Item -ItemType Directory -Force -Path $path | Out-Null
        Write-Host "Created folder: $path"
    }
    foreach ($act in $controllers[$ctrl].Split(",")) {
        $file = "$path\$act.cshtml"
        if (!(Test-Path $file)) {
            "@{
    ViewData[""Title""] = ""$ctrl - $act"";
}
<h2>$ctrl - $act</h2>
<p>This is the <b>$ctrl</b> controller’s <b>$act</b> view.</p>" | Out-File $file -Encoding UTF8
            Write-Host "Created view: $file"
        }
    }
}
