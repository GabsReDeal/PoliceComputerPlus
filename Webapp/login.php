

    <?php
        session_start();
        require('menu.php');
        require_once("functions.php");
    ?>
    <!-- Page Content -->
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <h2>Log-in to your account</h2>
                <form method="post" action="login.php">
                    <div class="row">
                        <label class="col-lg-1 col-form-label">Username</label>
                        <div class="col-lg-3">
                            <input class="form-control" type="text" name="username" placeholder="Enter your username"/><br/>
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-lg-1 col-form-label">Password</label>
                        <div class="col-lg-3">
                            <input class="form-control" type="password" name="password" placeholder="Enter your password"/><br/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-2">
                        <a href="register.php" class="btn btn-success">Register</a>
                        </div>
                        <div class="col-lg-1">
                            <!-- Empty col for styling -->
                        </div>
                        <div class="col-lg-2">
                            <input type="submit" class="btn btn-primary" name="login" value="Login">
                        </div>
                        
                    </div>
                    <br/><br/>
                    <div class="row">
                        <div class="col-lg-12">
                            <?php
                                if (isset($_SESSION['logged_user']))
                                {
                                    header("Location: index.php");
                                }

                                if(isset($_POST['login']))
                                {
                                    if((empty($_POST['username'])) || (empty($_POST['password'])))
                                    {
                                        echo "<div class='alert alert-danger'>Please input both username and password!</div>";
                                    }  
                                    else
                                    {
                                    
                                        $username = $_POST['username'];
                                        $password = $_POST['password'];

                                        $connection = connectToMySQL();

                                        $query = "select * from tbl_civilian
                                                    where ID = '$username' and Password = sha1('$password') ";

                                        $result = mysqli_query($connection, $query)
                                            or die("Error in query: " . mysqli_error($connection));

                                        $row = mysqli_fetch_row($result);
                                        $count = $row[0];

                                        if ($count > 0)
                                        {
                                            $_SESSION['logged_user'] = $username;
                                            $_SESSION['time'] = time();
                                            header("Location: index.php");
                                        }
                                        else
                                        {
                                            echo "<div class='alert alert-danger'>Username or Password incorrect!</div>";
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
    require("footer.php");
?>