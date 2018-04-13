$name = "Bohdanka"
$daylight = 9;
$evening = 18;
$night = 22;

$hour = Get-Date -UFormat "%H"
$greeting = ""

Switch($hour) 
{
    { $hour -le $daylight -and $hour -gt $night } { $greeting = "Good night"; Break; }
    { $hour -le $evening -and $hour -gt $daylight } { $greeting = "Good afternoon"; Break; }
    { $hour -le $night -and $hour -gt $evening } { $greeting = "Good evening"; Break; }
    Default { $greeting = "Good afternoon" }
}

$greeting += ", $name"
Write-Host $greeting
