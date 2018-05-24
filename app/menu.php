<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="GabsReDeal">

    <link rel="apple-touch-icon" sizes="76x76" href="images/favicon/apple-touch-icon.png">
    <link rel="icon" type="image/png" sizes="32x32" href="images/favicon/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="images/favicon/favicon-16x16.png">
    <link rel="manifest" href="images/favicon/site.webmanifest">
    <link rel="mask-icon" href="images/favicon/safari-pinned-tab.svg" color="#3b3b3b">
    <meta name="msapplication-TileColor" content="#da532c">
    <meta name="theme-color" content="#ffffff">

    <title>Police Computer +</title>

    <link href="css/style.css" rel="stylesheet">

    <!-- Bootstrap Core CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous">
</head>
<body>
    <!-- Navigation -->

    <nav class="navbar navbar-expand-lg navbar-dark bg-dark p-2 mb-5">
        <a class="navbar-brand pl-4" href="index.php"><img src="images/favicon/favicon.ico"/></a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link px-4" href="index.php">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link px-4" href="about.php">About</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link px-4" href="contact.php">Contact</a>
                </li>
                <?php
                    if (isset($_SESSION['logged_user']))
                    {
                        echo "<li class='nav-item'>
                            <a class='nav-link px-4' href='logout.php'>Logout</a>
                            </li>";
                    }
                ?>
            </ul>
        </div>
    </nav >