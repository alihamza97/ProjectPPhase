<?php
session_start();
session_destroy();

ob_start(); // ensures anything dumped out will be caught

// do stuff here
$url = 'http://i314865.hera.fhict.nl/vestrovestival/index.php'; // this can be set based on whatever

// clear out the output buffer
while (ob_get_status())
{
    ob_end_clean();
}

// no redirect
header( "Location: $url" );

