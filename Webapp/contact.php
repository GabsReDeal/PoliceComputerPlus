<?php
    session_start();
    require('menu.php');
    require_once("functions.php");
?>

<div class="container">
    <h2>Contact Us</h2>
    <div class="col-lg-12">
        <form method="post">
            <div class="form-row mt-3">
                <div class="form-group col-sm-6">
                    <label for="inputfName">First name</label>
                    <input type="text" class="form-control" name="fname" id="inputfName" placeholder="Enter your first name" required>
                </div>
                <div class="form-group col-sm-6">
                    <label for="inputlName">Last Name</label>
                    <input type="text" class="form-control" name="lname" id="inputlName" placeholder="Enter your last name" required>
                </div>
            </div>
            <div class="form-group">
                <label for="inputEmail">Email</label>
                <input type="email" class="form-control" name="email" id="inputEmail" placeholder="Enter your email" required>
            </div>
            <div class="form-row">
                <div class="form-group col-sm-12">
                    <label for="message">Message</label>
                    <textarea class="form-control" id="message" name="message" rows="6" style="resize:none" placeholder="Any issues or suggetions..." required></textarea>
                </div>
            </div>
            <button type="submit" name="submit" class="btn btn-block btn-primary">Submit</button>
        </form>        
    </div>
    <div class="col-lg-12 mt-3">
    <?php
        if(isset($_POST['submit']))
        {
            if((empty($_POST['fname'])) || (empty($_POST['lname'])) || (empty($_POST['email'])) || (empty($_POST['message'])))
            {
                echo "<div class='alert alert-danger'>Please input all information!</div>";
            }
            else
            {
                echo "<div class='alert alert-success'>Your message has been submitted!</div>";
            }
        }
    ?>
    </div>
</div>

<?php
    require("footer.php");
?>