
INSERT INTO EngCV
                      (EngID, Fname, Mname, Lname, [National], Certificate, EngStatus, DateOFjointly, DateOFbirthday, DateOfgraduation, Gender, integrity, UniName, 
                      UniLocation, EngWork, IDjoind, MoveDate, ReJoind, WorkAddress, WorkPhone, RemarksCV, Desesion, IdCard,RetailID)
SELECT     [ÇáÑŞã ÇáİÑÚí], ÇáÇÓã, [ÇÓã ÇáÃÈ], ÇáßäíÉ, ÇáÌäÓíÉ, ÇáŞÓã, 'Joind' AS expr1, [ÊÇÑíÎ ÇáÇäÊÓÇÈ], [ÊÇÑíÎ ÇáæáÇÏÉ] , 
                     [ÓäÉ ÇáÊÎÑÌ], ÇáÌäÓ, [ÇáÎÇäÉ æÑŞãåÇ], [ÇÓã ÇáÌÇãÚÉ], [ãŞÑ ÇáÌÇãÚÉ], ÇáÚãá, [ÑŞã ŞÑÇÑ ÇáÇäÊÓÇÈ], [ÊÇÑíÎ ÇáäŞá], 
                      [ŞÑÇÑ æÊÇÑíÎ ÇÚÇÏÉ ÇáÊÓÌíá], ÇáÚäæÇä, ÇáåÇÊİ, ãáÇÍÙÇÊ, [ŞÑÇÑ ÇáãÌáÓ], ÇáåæíÉ,[ÇáÑŞã ÇáİÑÚí]
FROM         CVs