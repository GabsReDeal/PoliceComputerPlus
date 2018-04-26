<?php
    function connectToMySQL()
    {
        $conn = mysqli_connect("localhost", "root", "", "police_database", "3307");
        if (mysqli_connect_errno())
        {
            echo "Error: Could not connect to database. Please try againlater";
            exit;
        }
        return $conn;
    }

    function getFullName($userID)
    {

        $connection = connectToMySQL();

        $query = "select * from tbl_civilian
                    where ID = '$userID'";

        $result = mysqli_query($connection, $query)
            or die("Error in query: " . mysqli_error($connection));

        while ($row = mysqli_fetch_assoc($result))
        {
            $username = $row['Name'] . " " . $row['Surname'];
        }            

        mysqli_free_result($result); // Clearing up memory

        mysqli_close($connection); // Closing Connection

        return $username;
    }
?>