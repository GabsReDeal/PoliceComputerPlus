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
            <?php
                if(!isDriver($_SESSION['logged_user']))
                {
                    echo "<div class='alert alert-danger text-center'>You do not own a driver's licence!</div>";
                    
                }
                else
                {
                    $licence_no = getForeignById($_SESSION['logged_user'], 'Licence_No', 'tbl_driver', 'ID');
            ?>
            <div class="row mb-3">
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Licence No</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo $licence_no?>' readonly>
                </div>
                <div class="col-sm-4">
                </div>
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Status</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getForeignById(getInformationById('Licence_No', $licence_no, 'Status_ID', 'tbl_driver'), 'Status', 'tbl_licence_status','Status_ID');?>' readonly>
                </div>
            </div>
            <div class="row mb-3">
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <a class="btn btn-outline-secondary" href="http://www.transport.gov.mt/land-transport/driving/penalty-points">Penalty Points</a>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('Licence_No', $licence_no, 'Points', 'tbl_driver')?>' readonly>
                </div>
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Citations</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('Licence_No', $licence_no, 'Citations', 'tbl_driver')?>' readonly>
                </div>
            </div>
            <?php
                if(!hasVehicle($licence_no))
                {
                    echo "<div class='alert alert-warning text-center'>You do not own any vehicles!</div>";
                    
                }
                else
                {
                    $vehicle = storeVehicle($licence_no);

                    for($i=0; $i<sizeof($vehicle); $i++)
                    { 
            ?>
            <div class="row pb-4">
                <div class="col-lg-12">
                    <hr/>
                    <h4>Vehicle <?php echo $i+1 ?></h4>
                </div>
            </div>
            <div class="row mb-3">
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Licence Plate</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo $vehicle[$i]?>' readonly>
                </div>
                
            </div>
            <div class="row mb-3">
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Make</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getForeignById(getForeignById(getInformationById('Licence_Plate', $vehicle[$i], 'Model_ID', 'tbl_vehicle'), 'Manufacturer_ID', 'tbl_vehicle_model','Model_ID'), 'Manufacturer', 'tbl_vehicle_manufacturer', 'Manufacturer_ID'); ?>' readonly>
                </div>
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Model</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getForeignById(getInformationById('Licence_Plate', $vehicle[$i], 'Model_ID', 'tbl_vehicle'), 'Model', 'tbl_vehicle_model','Model_ID'); ?>' readonly>
                </div>
                <div class="input-group mb-3 col-sm-4">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="basic-addon1">Year</span>
                    </div>
                    <input class="form-control" type='text' value='<?php echo getInformationById('Licence_Plate', $vehicle[$i], 'Year', 'tbl_vehicle')?>' readonly>
                </div>
            </div>
        </div>
    </div>
    
    <?php } } } //Closing the else for !isDriver, !hasVehicle and for loop ?>
    <div class="row">
        <div class="mx-auto">
            <a href="personal.php" class="btn btn-info mt-3 mb-3">View Personal Information</a>
        </div>
    </div>
</div>


<?php
    require("footer.php");
?>


