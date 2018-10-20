<?php

    session_start();

if (isset($_POST['login'])) {

    include 'dbh-inc.php';

    $uid = mysqli_real_escape_string($conn, $_POST['uid']);
    $pwd = mysqli_real_escape_string($conn, $_POST['pwd']);

    //Error handlers
    //Check if inputs are empty
    if(empty($uid) || empty($pwd)) {
        header("Location: ../index.php?login=empty");
        exit();
    } else {
        $sql = "SELECT * FROM visitor WHERE Username='$uid'";
        $result = mysqli_query($conn, $sql);
        $resultCheck = mysqli_num_rows($result);
        if ($resultCheck < 1) {
            header("Location: ../index.php?login=1");
            exit();
        } else {
            if ($row = mysqli_fetch_assoc($result))
                //De-hashing the password
                $hashedPwdCheck = password_verify($pwd, $row['Userpassword']);
            if ($hashedPwdCheck == false) {
                header("Location: ../index.php?login=error");
                exit();
            } elseif ($hashedPwdCheck == true) {
                //Log in the user here
                $_SESSION['u_id'] = $row['EventID'];
                $_SESSION['u_last'] = $row['LName'];
                $_SESSION['u_first'] = $row['FName'];
                $_SESSION['u_email'] = $row['Email'];
                $_SESSION['u_uid'] = $row['Username'];
                header("Location: ../index.php?login=succes");
                exit();
            }  else {
                header("Location: ../index.php?login=error");
                exit();
            }
        }
    }
}