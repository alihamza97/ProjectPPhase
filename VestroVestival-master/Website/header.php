<?php

    session_start();

if (isset($_SESSION['u_id'])) {

    echo "

<!DOCTYPE html>
<header>
    <div class=\"headerimg\">
        <img src= \"VestroVestival_LOGO_BIG_TPBG_TEXT.png\" />
    </div>    
    <div class=\"navbar\" id=\"navbar\">
        <a href=\"index.php\">Home</a>
        <a href=\"festival.php\">Festival</a>
        <a href=\"lineup.php\">Line-Up</a>
        <a href=\"campinglogin.php\">Camping</a>
        <a href=\"myaccount.php\">My Account</a>
        <a href=\"contact.php\">Contact</a>
        <b>| Hello ". $_SESSION['u_first']."! |</b>
        <div class=\"nav-login\">
                <form class=\"loginform\"  action=\"logout.php\" method=\"POST\">
                <button type=\"submit\" name=\"logout\"  >Logout</button>
            </form>
        </div>    
    </div>
</header>";
} else {
    echo "
<!DOCTYPE html>
<header>
    <div class=\"headerimg\">
        <img src= \"VestroVestival_LOGO_BIG_TPBG_TEXT.png\" />
    </div>    
    <div class=\"navbar\" id=\"navbar\">
        <a href=\"index.php\">Home</a>
        <a href=\"festival.php\">Festival</a>
        <a href=\"lineup.php\">Line-Up</a>
        <a href=\"camping.php\">Camping</a>
        <a href=\"tickets.php\">Tickets</a>
        <a href=\"contact.php\">Contact</a>        
        <div class=\"nav-login\">
            <form class=\"loginform\"  action=\"includes/login-inc.php\" method=\"POST\">
                <input type=\"text\" name =\"uid\" placeholder=\"Username\">
                <input type=\"password\" name=\"pwd\" placeholder=\"Password\">
                <button type=\"submit\" name=\"login\">Login</button>
            </form>
        </div>
    </div>
</header>";
}

