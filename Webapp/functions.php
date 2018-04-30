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

    function getInformationById($pk, $id, $column, $table)
    {
        $output = "N/a";

        $connection = connectToMySQL();

        if(!is_string($id))
        {
            $query = "SELECT * FROM $table
                    WHERE $pk = $id";
        }
        else
        {
            $query = "SELECT * FROM $table
                    WHERE $pk = '$id'";
        }

        $result = mysqli_query($connection, $query)
        or die("Error in query: " . mysqli_error($connection));

        while ($row = mysqli_fetch_assoc($result))
        {
            $output = $row[$column];
        }

        if(!empty($output))
        {
            return $output;
        }
        else if($output === '0')
        {
            return $output;
        }
        else
        {
            return "N/a";
        }
        
    }

    function getForeignById($id, $column, $table, $foreignPK)
    {
        $output = "N/a";

        $connection = connectToMySQL();

        if(!is_string($id))
        {
            $query = "SELECT * FROM $table
                    WHERE $foreignPK = $id";
        }
        else
        {
            $query = "SELECT * FROM $table
                    WHERE $foreignPK = '$id'";
        }
        

        $result = mysqli_query($connection, $query)
        or die("Error in query: " . mysqli_error($connection));

        while ($row = mysqli_fetch_assoc($result))
        {
            $output = $row[$column];
        }

        if(!empty($output))
        {
            return $output;
        }
        else if($output === '0')
        {
            return $output;
        }
        else
        {
            return "N/a";
        }
        
    }

    function isDriver($id)
    {
        $connection = connectToMySQL();

        $query = "SELECT * FROM tbl_driver
                    WHERE ID = '$id'";

        $result = mysqli_query($connection, $query)
        or die("Error in query: " . mysqli_error($connection));

        while ($row = mysqli_fetch_assoc($result))
        {
            $output = $row['Licence_No'];
        }

        if(!empty($output))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    function hasVehicle($licence_no)
    {
        $connection = connectToMySQL();

        $query = "SELECT * FROM tbl_vehicle
                    WHERE Licence_No = '$licence_no'";

        $result = mysqli_query($connection, $query)
        or die("Error in query: " . mysqli_error($connection));

        while ($row = mysqli_fetch_assoc($result))
        {
            $output = $row['Licence_No'];
        }

        if(!empty($output))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    function storeVehicle($licence_no)
    {
        $output = array();

        $connection = connectToMySQL();

        $query = "SELECT * FROM tbl_vehicle
                    WHERE Licence_No = '$licence_no'";

        $result = mysqli_query($connection, $query)
        or die("Error in query: " . mysqli_error($connection));

        while ($row = mysqli_fetch_assoc($result))
        {
            array_push($output, $row['Licence_Plate']);
        }

        return $output;
    }

    function randomPassword()
    {
        $password = '';
        $characters = array_merge(range(0,9), range('a','z'), range('A','Z'));

        for($i=0; $i < 12; $i++) {
            $password .= $characters[mt_rand(0, count($characters) - 1)];
        }

        return $password;
    }
?>