<!DOCTYPE html>

<html>
    
    <link rel="stylesheet" type="text/css" href=ticketsstyle.css>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>

<head>
    
</head>
    
<?php include('header.php'); ?>
    
<body>
    
    <div class="flex-container">
        <div class="flex-item">
            <form class="tickets-form" action="includes/tickets-inc.php" method="POST">
                <h1>Fill in the sign up form!</h1>
                <input type="text" name="last" placeholder="Lastname">
                <br>
                <input type="text" name="first" placeholder="Firstname">
                <br>
                <input type="text" name="email" placeholder="E-mail">
                <br>
                <input type="text" name="uid" placeholder="Username">
                <br>
                <input type="password" name="pwd" placeholder="Password">
                <br>
                <input type="text" name="pstc" placeholder="Postcode" maxlength="6">
                <br>
                <input type="text" name="str" placeholder="Street">
                <br>
                <input type="text" name="housenr" placeholder="Housenumber">
                <br>
                <input type="text" name="city" placeholder="City">
                <br>
                <input type="text" name="cntr" placeholder="Country">
                <br>
                <input type="number" name="phonenr" placeholder="Phonenumber">
                <br>
                <!--<select name="select">
                    <option value="selectticket" selected>Select your ticket</option>
                    <option value="allday">Three-day Ticket (Fri Sat Sun)</option>
                    <option value="frifri">One Day Ticket Friday</option>
                    <option value="satsat">One Day Ticket Saturday</option>
                    <option value="sunsun">One Day Ticket Sunday</option>
                </select>-->
                <div class="checkboxes">
                    <p>___________________</p>
                    <label for="checkbox">Fri  Ticket</label>
                    <input type="checkbox" id="frifri" name="frifri" value="frifri" onclick="campFunc()"><!--value="frifri"-->
                    <p>___________________</p>
                    <label for="checkbox">Sat Ticket</label>
                    <input type="checkbox" id="satsat" name="satsat" value="satsat" onclick="campFunc()"><!--value="satsat"-->
                    <p>___________________</p>
                    <label for="checkbox">Sun Ticket</label>
                    <input type="checkbox" id="sunsun" name="sunsun" value="sunsun" onclick="campFunc()"><!--value="sunsun"-->
                    <p>___________________</p>
                    <br>
                    <label for="checkbox" id="camplabel" style="display:none">Campingspot</label>
                    <input type="checkbox" style="display:none" id="campcheck" name="campcheck" value="true"</input>
                    <br>
                    <p id="campline" style="display:none">___________________</p>


                    <script>
                        function campFunc() {
                            var frifri = document.getElementById("frifri");
                            var satsat = document.getElementById("satsat");
                            var sunsun = document.getElementById("sunsun");
                            var camplabel = document.getElementById("camplabel");
                            var campcheck = document.getElementById("campcheck");
                            var campline = document.getElementById("campline");
                            /*if (frifri.checked == true && satsat.checked == true || satsat.checked == true && sunsun.checked == true){
                                camplabel.style.display = "inline";
                                campcheck.style.display = "inline";
                                campline.style.display = "inline";
                            } else {
                                camplabel.style.display = "none";
                                campcheck.style.display = "none";
                                campline.style.display = "none";
                            }*/
                        }
                        function calcPriceFunc() {
                            var nrperson = document.getElementById ("nrperson");
                            var nrpersonvalue = nrperson.options[nrperson.selectedIndex].value;
                            var total = 10.00 + (nrpersonvalue*20.00);
                            var costcamp = document.getElementById("costcamp");
                            costcamp.value = total.toFixed(2);
                            document.getElementById("nrpersonzero").style.display = "none";
                        }

                        function campingNumber() {
                            var campnr = document.getElementById ("campnr");
                            var campnrvalue = campnr.options[campnr.selectedIndex].value;
                            var campingnr = document.getElementById("campingnr");
                            campingnr.value = campnrvalue;
                            document.getElementById("campnrzero").style.display = "none";
                        }

                        function campingColor() {
                            var campcolor = document.getElementById ("campcolor");
                            var campcolorvalue = campcolor.options[campcolor.selectedIndex].text;
                            var campingcolor = document.getElementById("campingcolor");
                            campingcolor.value = campcolorvalue;
                        }
                    </script>

                </div>
                <br>

                <button type="submit" name="order">Order</button>
            </form>
        </div>
        <!--
        <div class="flex-item">
            <label>Select your campingspot:</label>
            <br>
            <label>Campingspot color</label>
            <select value="campcolor" id="campcolor" name="campcolor" onchange="campingColor()"</label>
            <option value="purple">Purple</option>
            <option value="blue">Blue</option>
            <option value="yellow">Yellow</option>
            </select>
            <input type="text" id="campingcolor" name="campingcolor" style="display:none">
            <br>
            <label>Campingspot number</label>
            <select value="campnr" id="campnr" name="campnr" onchange="campingNumber()"</label>
            <option value="0" id="campnrzero" style="">0</option>
            <option value="1">1</option>
            <option value="2">2</option>
            <option value="3">3</option>
            <option value="4">4</option>
            <option value="5">5</option>
            <option value="6">6</option>
            <option value="7">7</option>
            <option value="8">8</option>
            <option value="9">9</option>
            <option value="10">10</option>
            <option value="11">11</option>
            <option value="12">12</option>
            <option value="13">13</option>
            <option value="14">14</option>
            <option value="15">15</option>
            <option value="16">16</option>
            <option value="17">17</option>
            <option value="18">18</option>
            <option value="19">19</option>
            <option value="20">20</option>
            <option value="21">21</option>
            <option value="22">22</option>
            <option value="23">23</option>
            <option value="24">24</option>
            <option value="25">25</option>
            <option value="26">26</option>
            <option value="27">27</option>
            <option value="28">28</option>
            <option value="29">29</option>
            <option value="30">30</option>
            <option value="31">31</option>
            <option value="32">32</option>
            <option value="33">33</option>
            <option value="34">34</option>
            <option value="35">35</option>
            <option value="36">36</option>
            <option value="37">37</option>
            <option value="38">38</option>
            <option value="39">39</option>
            <option value="40">40</option>
            <option value="41">41</option>
            <option value="42">42</option>
            <option value="43">43</option>
            <option value="44">44</option>
            <option value="45">45</option>
            <option value="46">46</option>
            <option value="47">47</option>
            <option value="48">48</option>
            <option value="49">49</option>
            <option value="50">50</option>
            </select>
            <input type="number" id="campingnr" name="campingnr" style="display:none">
            <br>
            <label>Number of persons</label>
            <select value="nrperson" id="nrperson" name="nrperson" onchange="calcPriceFunc()">
                <option id="nrpersonzero" style="" value="0">0</option>
                <option value="1">1</option>
                <option value="2">2</option>
                <option value="3">3</option>
                <option value="4">4</option>
                <option value="5">5</option>
                <option value="6">6</option>
            </select>

            <form action="includes/campspot-inc.php" method="POST">
                <label>Price: €</label>
                <input type="number" id="costcamp" readonly>
                <button id="book" name="book" style="display:none" >Book</button>

            </form>
            <div class="flex-containerimgcampzoom">
            </div>
        </div>-->

    </div>

</body>
    
<footer>
    
</footer>
    
</html>