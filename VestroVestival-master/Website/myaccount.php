

<html>

<!--<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
<link rel="stylesheet" type="text/css" href=style.css>-->

<link rel="stylesheet" type="text/css" href=myaccountstyle.css>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>

<head>

</head>

<?php include('header.php');
include_once 'includes/dbh-inc.php'; ?>

<body>


        <?php
        $id = $_SESSION['u_id'];
        $sql = "SELECT * FROM visitor WHERE EventID = '$id';";
        //mysqli_query($conn, "SELECT * FROM visitor WHERE Username='admin';")
        $result = mysqli_query($conn, $sql);
        $resultCheck = mysqli_num_rows($result);
        if ($resultCheck > 0) {
            $row = mysqli_fetch_assoc($result);
            echo '
                <div class="flex-container">
                    <div class="flex-item">
                        <label>ID: </label>
                        <h3>' . $row['EventID'] . '</h3>
                        <br>
                        <label>Username: </label>
                        <h3>' . $row['Username'] . '</h3>
                        <br>
                        <label>Last Name: </label>
                        <h3>' . $row['LName'] . '</h3>
                        <br>
                        <label>First Name: </label>
                        <h3>' . $row['FName'] . '</h3>
                        <br>
                        <label>Email: </label>
                        <h3>' . $row['Email'] . '</h3>
                        <br>
                        <label>Balance: €</label>
                        <h3>' . $row['PresentBalance'] . ',00</h3>
                        <br>
                        <label>Ticket Type: </label>
                        <h3>' . $row['TicketType'] . '</h3>
                        <br>
                    </div>
                </div>';
        } else {
            header("Location: ../myaccount.php?trytoreload");
            exit();
        }
        ?>

        <div class="flex-container">
            <div class="flex-item">
                <form action="includes/myaccount-inc.php" method="POST">
                    <label>Increase Account Balance:</label>
                    <br>
                    <label>€</label>
                    <input type="number" id="incamount" name="incamount">
                    <button id="increase" name="increase">+</button>
                </form>
            </div>
        </div>


<script>

</script>
</body>

<footer>

</footer>

</html>