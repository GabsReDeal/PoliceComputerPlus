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
                    echo "<h2>Welcome ". getFullName($_SESSION['logged_user']) . "</h2><br/>";
                }
                else 
                {
                    header("Location: login.php");
                }
            ?>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12">
            <h3></h3>
        </div>
    </div>
</div>


<?php
    require("footer.php");
?>