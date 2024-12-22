CREATE DATABASE TrainReservation;
USE TrainReservation;
---------------------------------------------------------------------------------
 CREATE TABLE Trains (
    TrainNo INT PRIMARY KEY, 
    TrainName VARCHAR(50) NOT NULL,
    Total1A INT , 
    Available1A int ,
    Total2A INT,  
    Available2A INT , 
    TotalSleeper INT , 
    AvailableSleeper INT ,
    Source VARCHAR(50) NOT NULL, 
    Destination VARCHAR(50) NOT NULL, 
    IsActive BIT DEFAULT 1 
);
------------------------------------------------------------------------------------------
 CREATE TABLE Bookings (
    BookingID INT IDENTITY PRIMARY KEY, 
    TrainNo INT NOT NULL, 
    PassengerName VARCHAR(50) NOT NULL, 
    Class VARCHAR(20) NOT NULL CHECK (Class IN ('1A', '2A', 'Sleeper')), 
    BerthsBooked INT NOT NULL,
    JourneyDate DATE NOT NULL,
    Status VARCHAR(20) DEFAULT 'Booked' CHECK (Status IN ('Booked', 'Cancelled')), 
    FOREIGN KEY (TrainNo) REFERENCES Trains(TrainNo)
);
INSERT INTO Trains (TrainNo, TrainName, Total1A, Available1A, Total2A, Available2A, TotalSleeper, AvailableSleeper, Source, Destination, IsActive)
VALUES
(12755, 'Chennai Express', 50, 50, 100, 100, 200, 200, 'Chennai', 'Delhi', 1),
(12756, 'Delhi Express', 20, 20, 50, 50, 100, 100, 'Delhi', 'Chennai', 1);
select  * from trains
 select * from bookings
 ---------------------------------------------------------------------------------------------------------------------
 CREATE or alter PROCEDURE AddTrain
    @TrainNo INT,
    @TrainName VARCHAR(50),
    @Total1A INT,
    @Total2A INT,
    @TotalSleeper INT,
    @Source VARCHAR(50),
    @Destination VARCHAR(50)
AS
BEGIN
    INSERT INTO Trains
    (TrainNo, TrainName, Total1A, Total2A, TotalSleeper, Available1A, Available2A, AvailableSleeper, Source, Destination, IsActive)
    VALUES
    (@TrainNo, @TrainName, @Total1A, @Total2A, @TotalSleeper, @Total1A, @Total2A, @TotalSleeper, @Source, @Destination, 1);
END;
-------------------------------------------------------------------------------------------
CREATE or alter PROCEDURE ModifyTrain
    @TrainNo INT,
    @TrainName VARCHAR(50),
    @Source VARCHAR(50),
    @Destination VARCHAR(50)
AS
BEGIN
    UPDATE Trains 
    SET TrainName = @TrainName, Source = @Source, Destination = @Destination
    WHERE TrainNo = @TrainNo AND IsActive = 1;
END;
 ------------------------------------------------------------------------------------------------------------------------
CREATE or alter PROCEDURE DeleteTrain
    @TrainNo INT
AS
BEGIN
    UPDATE Trains 
    SET IsActive = 0
    WHERE TrainNo = @TrainNo;
END;
---------------------------------------------------------------------------------------------------------------------
CREATE or alter PROCEDURE GetTrainsBySourceDestination
    @Source VARCHAR(100),
    @Destination VARCHAR(100)
AS
BEGIN
    SELECT TrainNo, TrainName, Source, Destination, Available1A, Available2A, AvailableSleeper
    FROM Trains
    WHERE Source = @Source AND Destination = @Destination;
END;
---------------------------------------------------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE BookTicket
    @TrainNo INT,
    @PassengerName VARCHAR(50),
    @Class VARCHAR(20),
    @BerthsBooked INT,
    @JourneyDate DATE
AS
BEGIN
    
    DECLARE @AvailableBerths INT;
 
    
    IF @Class = '1A'
    BEGIN
        SELECT @AvailableBerths = Available1A FROM Trains WHERE TrainNo = @TrainNo AND IsActive = 1;
    END
    ELSE IF @Class = '2A'
    BEGIN
        SELECT @AvailableBerths = Available2A FROM Trains WHERE TrainNo = @TrainNo AND IsActive = 1;
    END
    ELSE IF @Class = 'Sleeper'
    BEGIN
        SELECT @AvailableBerths = AvailableSleeper FROM Trains WHERE TrainNo = @TrainNo AND IsActive = 1;
    END
    ELSE
    BEGIN
        PRINT 'Booking failed. Invalid class.';
        RETURN;
    END
 
    
    IF @AvailableBerths IS NULL
    BEGIN
        PRINT 'Booking failed. Train not found or inactive.';
        RETURN;
    END
 
    IF @AvailableBerths >= @BerthsBooked
    BEGIN
       
        IF @Class = '1A'
        BEGIN
            UPDATE Trains SET Available1A = Available1A - @BerthsBooked WHERE TrainNo = @TrainNo;
        END
        ELSE IF @Class = '2A'
        BEGIN
            UPDATE Trains SET Available2A = Available2A - @BerthsBooked WHERE TrainNo = @TrainNo;
        END
        ELSE IF @Class = 'Sleeper'
        BEGIN
            UPDATE Trains SET AvailableSleeper = AvailableSleeper - @BerthsBooked WHERE TrainNo = @TrainNo;
        END
 
        
        INSERT INTO Bookings (TrainNo, PassengerName, Class, BerthsBooked, JourneyDate, Status)
        VALUES (@TrainNo, @PassengerName, @Class, @BerthsBooked, @JourneyDate, 'Booked');
 
        PRINT 'Booking successful.';
    END
    ELSE
    BEGIN
        PRINT 'Booking failed. Not enough berths available.';
    END
END;
------------------------------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE CancelTicket
    @BookingID INT
AS
BEGIN
    
    DECLARE @TrainNo INT, @Class VARCHAR(20), @BerthsBooked INT, @Status VARCHAR(20);
 
    
    SELECT
        @TrainNo = TrainNo,
        @Class = Class,
        @BerthsBooked = BerthsBooked,
        @Status = Status
    FROM Bookings
    WHERE BookingID = @BookingID;
 
    
    IF @Status = 'Booked'
    BEGIN
        
        IF @Class = '1A'
        BEGIN
            UPDATE Trains SET Available1A = Available1A + @BerthsBooked WHERE TrainNo = @TrainNo;
        END
        ELSE IF @Class = '2A'
        BEGIN
            UPDATE Trains SET Available2A = Available2A + @BerthsBooked WHERE TrainNo = @TrainNo;
        END
        ELSE IF @Class = 'Sleeper'
        BEGIN
            UPDATE Trains SET AvailableSleeper = AvailableSleeper + @BerthsBooked WHERE TrainNo = @TrainNo;
        END
 
        
        UPDATE Bookings SET Status = 'Cancelled' WHERE BookingID = @BookingID;
 
        PRINT 'Cancellation successful.';
    END
    ELSE
    BEGIN
        PRINT 'Cancellation failed. Booking not found or already cancelled.';
    END
END;
--------------------------------------------------------------------------------------------------------
CREATE or alter PROCEDURE ShowAllTrains
AS
BEGIN
    SELECT TrainNo, TrainName, Source, Destination,
           Available1A, Available2A, AvailableSleeper
    FROM Trains
    WHERE IsActive = 1
    ORDER BY TrainNo;
END
----------------------------------------------------------------------------------------------------------------------
CREATE or alter PROCEDURE ShowAllBookings
AS
BEGIN
    SELECT BookingID, TrainNo, PassengerName, Class, BerthsBooked, JourneyDate, Status
    FROM Bookings
    ORDER BY JourneyDate DESC;
END