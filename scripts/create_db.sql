CREATE TABLE TourLog(
    Id int primary key,
    DateTime timestamptz not null,
    Report varchar(1024) not null ,
    LogDistanceInKm float8 not null,
    TotalTime interval default null,
    Rating int not null
)