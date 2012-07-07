ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [StudentMonitoringDb], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

