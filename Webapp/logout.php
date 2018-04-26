<?php
    session_start();

    unset($_SESSION['logged_user']);
    unset($_SESSION['time']);
    session_destroy();

    header("Location: index.php");
?>