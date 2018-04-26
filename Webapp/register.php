<?php
    session_start();
    require("menu.php");
    require_once("functions.php");
?>

<div class="container">
        <div class="row">
            <div class="col-lg-12">
                <h2>Register</h2>
                <form method="post" action="register.php">
                    <div class="row">
                        <label class="col-lg-2 col-form-label">ID Number <br/>(7 digits, 1 letter)</label>
                        <div class="col-lg-2">
                            <input class="form-control" type="text" name="username" placeholder="Ex. 0123456M"/><br/>
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-lg-2 col-form-label">Password</label>
                        <div class="col-lg-2">
                            <input class="form-control" type="password" name="password" placeholder="Enter your password"/><br/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">
                            <input type="submit" class="btn btn-primary" name="submit" value="Submit">
                        </div>
                    </div>
                    <br/><br/>
                    <div class="row">
                        <div class="col-lg-4">
                            <?php
                                if (isset($_SESSION['logged_user']))
                                {
                                    header("Location: index.php");
                                }

                                if(isset($_POST['submit']))
                                {
                                    if((empty($_POST['username'])) || (empty($_POST['password'])))
                                    {
                                        echo "<span class='alert alert-danger'>Please input your ID including 7 digits and a letter!</span>";
                                    }  
                                    else
                                    {
                                    
                                        $username = $_POST['username'];
                                        $password = $_POST['password'];

                                        $connection = connectToMySQL();

                                        $query = "SELECT * FROM tbl_civilian
                                                    WHERE ID = '$username' AND Password IS NULL";

                                        $result = mysqli_query($connection, $query)
                                            or die("Error in query: " . mysqli_error($connection));

                                        $row = mysqli_fetch_row($result);
                                        $count = $row[0];

                                        if ($count > 0)
                                        {
                                            $query = "UPDATE tbl_civilian
                                                    SET Password = sha1('$password')
                                                    WHERE ID = '$username' ";
                                            mysqli_query($connection, $query)
                                            or die("Error in query: " . mysqli_error($connection));

                                            echo "<span class='alert alert-success'>Your account has been created with the desired password.</span>";
                                        }
                                        else
                                        {
                                            echo "<span class='alert alert-danger'>Your ID is incorrect or an account is already registered!</span>";
                                        }
                                    }   
                                }
                            ?>
                        </div>
                    </div>
                </form>

                
            </div>
        </div>
    </div>


<?php
    require("menu.php");
?>