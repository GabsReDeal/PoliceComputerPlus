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
        <div class="col-sm-10">
            <div class="row pt-2 pb-4">
                <div class="col-lg-6">
                    <h2>Personal Information</h2>
                </div>
            </div>
            <div class="row mb-3">
                <div class="input-group col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">ID</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo $_SESSION['logged_user'];?>' readonly>
                </div>
                
            </div>
        </div>
        <!-- <div class="col-sm-2"> -->
            <div class='mx-auto'>
                <img class='profilePic' src='images/<?php echo $_SESSION['logged_user']; ?>.png' alt='<?php echo $_SESSION['logged_user'];?>'>
            </div>
        <!-- </div> -->
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div class="row pt-3">
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Surname</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('ID', $_SESSION['logged_user'], 'Surname', 'tbl_civilian');?>' readonly>
                </div>
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Name</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('ID', $_SESSION['logged_user'], 'Name', 'tbl_civilian');?>' readonly>
                </div>
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Middle</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('ID', $_SESSION['logged_user'], 'Middle_Name', 'tbl_civilian');?>' readonly>
                </div>
            </div>
            <div class="row pt-3">
                <div class="input-group mb-3 col-lg-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">DoB</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('ID', $_SESSION['logged_user'], 'DoB', 'tbl_civilian');?>' readonly>
                </div>
                <div class="input-group mb-3 col-lg-2">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Gender</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('ID', $_SESSION['logged_user'], 'Gender', 'tbl_civilian');?>' readonly>
                </div>
                <div class="input-group mb-3 col-lg-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">SSN</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('ID', $_SESSION['logged_user'], 'SSN', 'tbl_civilian');?>' readonly>
                </div>
                <div class="input-group mb-3 col-lg-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Home</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('ID', $_SESSION['logged_user'], 'Home_Phone', 'tbl_civilian');?>' readonly>
                </div>
            </div>
            <div class="row pt-3">
                <div class="input-group mb-3 col-lg-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">House</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('ID', $_SESSION['logged_user'], 'House_Number_Name', 'tbl_civilian');?>' readonly>
                </div>
                <div class="input-group mb-3 col-lg-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Street</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getForeignById(getInformationById('ID', $_SESSION['logged_user'], 'Street_ID', 'tbl_civilian'), 'Street', 'tbl_street', 'Street_ID');?>' readonly>
                </div>
                <div class="input-group mb-3 col-lg-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Locality</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getForeignById(getForeignById(getInformationById('ID', $_SESSION['logged_user'], 'Street_ID', 'tbl_civilian'), 'Locality_ID', 'tbl_street', 'Street_ID'), 'Locality', 'tbl_locality', 'Locality_ID');?>' readonly>
                </div>
            </div>
        </div>
        <div class="mx-auto">
            <a href="vehicle.php" class="btn btn-info mt-3 mb-3">View Vehicle Information</a>
        </div>
    </div> 
</div>


<?php
    require("footer.php");
?>