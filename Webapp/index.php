<?php
    session_start();
    require("menu.php");
    require_once("functions.php");

    
?>

<div class="container">
    <div class="row">
        <div class="col-lg-12">
            <?php
                if (isset($_SESSION['logged_user']))
                {
                    echo "<h3 class='text-center'>Welcome </h3><h2 class='text-center'>". getFullName($_SESSION['logged_user']) . "!</h2><br/>";
                }
                else 
                {
                    header("Location: login.php");
                }
            ?>
            <h3 class="text-center red">Access your personal information at the click of a button!</p></h3>
        </div>
    </div>
    <br/><br/>
    <div class="row">
        <div class="col-sm-2">
            <!-- Empty div for styling -->
        </div>
        <div class="col-sm-4">
            <a href="personal.php" class="btn btn-info btn-block">View Personal Information</a><br/>
        </div>
        <div class="col-sm-4">
            <a href="vehicle.php" class="btn btn-info btn-block">View Vehicle Information</a>
        </div>
    </div>
</div>



<?php
    require("footer.php");
?>