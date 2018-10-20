<?php

if (isset($_POST['order'])) {

    include_once 'dbh-inc.php';


    $last = mysqli_real_escape_string($conn, $_POST['last']);
    $first = mysqli_real_escape_string($conn, $_POST['first']);
    $email = mysqli_real_escape_string($conn, $_POST['email']);
    $uid = mysqli_real_escape_string($conn, $_POST['uid']);
    $pwd = mysqli_real_escape_string($conn, $_POST['pwd']);
    $pstc = mysqli_real_escape_string($conn, $_POST['pstc']);
    $str = mysqli_real_escape_string($conn, $_POST['str']);
    $housenr = mysqli_real_escape_string($conn, $_POST['housenr']);
    $city = mysqli_real_escape_string($conn, $_POST['city']);
    $cntr = mysqli_real_escape_string($conn, $_POST['cntr']);
    $phonenr = mysqli_real_escape_string($conn, $_POST['phonenr']);
    $frifri = $_POST['frifri'];
    $satsat = $_POST['satsat'];
    $sunsun = $_POST['sunsun'];
    $campcheck = $_POST['campcheck'];
    $tickettype = "huh";
    $campticket = false;
    $resultCheckeventid = 1;

    $campingcolor = mysqli_real_escape_string($conn, $_POST['campingcolor']);
    $campingnumber = mysqli_real_escape_string($conn, $_POST['campingnumber']);
    $costcamp = mysqli_real_escape_string($conn, $_POST['costcamp']);
    $nrperson = mysqli_real_escape_string($conn,$_POST['nrperson']);
    $campid = 2;
    $campday = 1;
    $campspot = mysqli_real_escape_string($conn, $_POST['campingcolor']).mysqli_real_escape_string($conn, $_POST['campingnumber']);


    while ($resultCheckeventid > 0)
    {
        $eventid = mt_rand(10000, 99999);
        $sqleventid = "SELECT * FROM visitor WHERE EventID = '$eventid'";
        $resulteventid = mysqli_query($conn, $sqleventid);
        $resultCheckeventid = mysqli_num_rows($resulteventid);
    }

    if (($_POST['frifri'] == "frifri") && ($_POST['satsat'] != "satsat") && ($_POST['sunsun'] != "sunsun")) {
        $tickettype = "frifri";
    } elseif (($_POST['frifri'] != "frifri") && ($_POST['satsat'] == "satsat") && ($_POST['sunsun'] != "sunsun")) {
        $tickettype = "satsat";
    } elseif (($_POST['frifri'] != "frifri") && ($_POST['satsat'] != "satsat") && ($_POST['sunsun'] == "sunsun")) {
        $tickettype = "sunsun";
    } elseif (($_POST['frifri'] == "frifri") && ($_POST['satsat'] == "satsat") && ($_POST['sunsun'] != "sunsun")) {
        $tickettype = "frisat";
    } elseif (($_POST['frifri'] != "frifri") && ($_POST['satsat'] == "satsat") && ($_POST['sunsun'] == "sunsun")) {
        $tickettype = "satsun";
    } elseif (($_POST['frifri'] == "frifri") && ($_POST['satsat'] == "satsat") && ($_POST['sunsun'] == "sunsun")) {
        $tickettype = "allday";
    } else {
        $tickettype = "frisun";
    }

    //Error handlers
    //Check for empty fields
    if (empty($first) || empty($last) || empty($email) || empty($uid) || empty($pwd) || empty($pstc) || empty($str) || empty($housenr) || empty($city) ||
        empty($cntr) || empty($phonenr)) {
        header("Location: ../tickets.php?tickets=empty");
        exit();
    } else {
        //Check if input characters are valid
        if (!preg_match("/^[a-zA-Z]*$/", $first) || !preg_match("/^[a-zA-Z]*$/", $last)) {
            header("Location: ../tickets.php?tickets=invalid");
            exit();
        } else {
            //Check if email is valid
            if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
                header("Location: ../tickets.php?tickets=email");
                exit();
            } else {
                include_once 'dbh-inc.php';
                $sql = "SELECT * FROM visitor WHERE Username='$uid'";
                $result = mysqli_query($conn, $sql);
                $resultCheck = mysqli_num_rows($result);

                if ($resultCheck > 0) {
                    header("Location: ../tickets.php?tickets=usernametaken");
                    exit();
                } else {
                    include_once 'dbh-inc.php';
                    //Hashing the password
                    $hashedPwd = password_hash($pwd, PASSWORD_DEFAULT);
                    //Insert the user into database
                    $sql = "INSERT INTO visitor (EventID, LName, FName, Email, Username, Userpassword, Postcode, Street, Housenumber,
                                                  City, Country, Phonenumber, TicketType, CampSpot) 
                                                  VALUES ('$eventid', '$last', '$first', '$email', '$uid', '$hashedPwd', '$pstc', '$str',
                                                   '$housenr', '$city', '$cntr', '$phonenr', '$tickettype', '$campspot');";
                    mysqli_query($conn, $sql);
                    header("Location: ../tickets.php?tickets=success");
                    exit();
                }
            }
        }
    }

} else {
    header("Location: ../tickets.php");
    exit();
}