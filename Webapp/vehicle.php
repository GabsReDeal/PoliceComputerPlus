<?php
    session_start();
    require("menu.php");
    require_once("functions.php");

    if (!isset($_SESSION['logged_user']))
    {
        header("Location: login.php");
    }
?>

<div class="container-fluid">
    <div class="row">
        <div class="col-lg-12">
            <div class="row pt-2 pb-4">
                <div class="col-lg-6">
                    <h2>Vehicle Information</h2>
                </div>
            </div>
            <div class="row mb-3">
                <div class="input-group col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Licence No</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo'To be implemented'?>' readonly>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="mx-auto">
            <a href="personal.php" class="btn btn-info mt-3 mb-3">View Personal Information</a>
        </div>
    </div>
</div>


<?php
    require("footer.php");
?>