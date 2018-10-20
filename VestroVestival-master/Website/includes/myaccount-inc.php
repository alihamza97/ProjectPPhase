<?php

if (isset($_POST['increase'])) {

    include_once 'dbh-inc.php';
    $incamount = mysqli_real_escape_string($conn, $_POST['incamount']);

    $id = $_SESSION['u_id'];
    $uid = $_SESSION['u_uid'];

    $sql = "SELECT PresentBalance FROM visitor WHERE EventID='$id';";
    $result = mysqli_query($conn, $sql);
    $row = mysqli_fetch_assoc($result);

    $presentbal = $incamount+$row['PresentBalance'];
    $sql3 = "$presentbal"." WHERE EventID = '$id'";

    $sql2 = "UPDATE visitor SET PresentBalance = '$presentbal';";
    mysqli_query($conn, $sql2);
    header("Location: ../myaccount.php?balance=upgraded");
    exit();

}