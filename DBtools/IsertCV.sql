
INSERT INTO EngCV
                      (EngID, Fname, Mname, Lname, [National], Certificate, EngStatus, DateOFjointly, DateOFbirthday, DateOfgraduation, Gender, integrity, UniName, 
                      UniLocation, EngWork, IDjoind, MoveDate, ReJoind, WorkAddress, WorkPhone, RemarksCV, Desesion, IdCard,RetailID)
SELECT     [����� ������], �����, [��� ����], ������, �������, �����, 'Joind' AS expr1, [����� ��������], [����� �������] , 
                     [��� ������], �����, [������ ������], [��� �������], [��� �������], �����, [��� ���� ��������], [����� �����], 
                      [���� ������ ����� �������], �������, ������, �������, [���� ������], ������,[����� ������]
FROM         CVs