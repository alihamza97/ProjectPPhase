<?php

if (isset($_POST['book'])) {

    include_once 'dbh-inc.php';

    $campingnumber = mysqli_real_escape_string($conn, $_POST['campingnr']);


    $sql = "SELECT * FROM campingspot WHERE CampSpotID='$campingnumber'";
    $result = mysqli_query($conn, $sql);
    $resultCheck = mysqli_num_rows($result);
    $costcamp = mysqli_real_escape_string($conn, $_POST['costcamp']);
    $nrperson = mysqli_real_escape_string($conn,$_POST['nrperson']);

    if ($resultCheck > 0) {
        header("Location: ../campinglogin.php?spot=campingspotTaken");
        exit();
    } else {
        include_once 'dbh-inc.php';
        $sql2 = "INSERT INTO campingspot (CampingSpotID, CampDay, IsAvailable, NumberOfParticipants, Price, HasPaid) 
                                  VALUES ('$campingnumber', 1, 0, 5, 110, 1);";
        mysqli_query($conn, $sql2);
        header("Location: ../campinglogin.php?camping=success");
        exit();
    }





}