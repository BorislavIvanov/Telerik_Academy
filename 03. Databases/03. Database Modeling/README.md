#Database Modeling

**Exercises:**

1. Create the following database diagram in SQL Server:

 ![](https://raw.githubusercontent.com/BorislavIvanov/Telerik_Academy/master/Resources/Exercise%20images/Database%20Modeling%20-%20Exercise%201.JPG)

2. Fill some sample data in the tables with SQL Server Management Studio.

3. Typical universities have: ``faculties``, ``departments``, ``professors``, ``students``, ``courses``, etc. ``Faculties`` have ``name`` and could have several ``departments``. Each ``department`` has ``name``, ``professors`` and ``courses``. Each ``professor`` has ``name``, a set of ``titles`` (Ph. D, academician, senior assistant, etc.) and a set of ``courses``. Each ``course`` consists of several ``students``. Each ``student`` belongs to some ``faculty`` and to several of the ``courses``. Your task is to create a ``data model`` (E/R diagram) for the typical university in SQL Server using ``SQL Server Management Studio (SSMS)``.
