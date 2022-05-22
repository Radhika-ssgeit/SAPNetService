Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports SAP.Middleware.Connector
Imports System.DirectoryServices
Imports System.Data
Imports System.Web.Configuration
Imports NetConnection


' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://shafiqgul.com/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService
    Private my_ecc As RfcDestination
    Public strVal As String

    <WebMethod()> _
    Public Function GetEmployeeDataByFileNo(ByVal FileNo As String) As DataSet
        On Error Resume Next
        '  Try

        'If Not RfcDestinationManager.IsDestinationConfigurationRegistered() Then
        RfcDestinationManager.RegisterDestinationConfiguration(New NetConnection.ECCDestinationConfig)
        '    End If
        my_ecc = RfcDestinationManager.GetDestination("ECDCLNT140")
            Dim EmployeeAPI As IRfcFunction = my_ecc.Repository.CreateFunction("ZBAPI_GETEMPLOYEE")
            EmployeeAPI.SetValue("PERSNO", FileNo)

            EmployeeAPI.Invoke(my_ecc)

            Dim FullName As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ENAME")
            Dim JobTitle As String = EmployeeAPI.GetStructure("EMPDATA").GetString("JOBTITLE")
            Dim JobGrade As String = EmployeeAPI.GetStructure("EMPDATA").GetString("JOBGRADE")
            Dim BASICSAL As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BASICSAL")
            Dim NATIONALITY As String = EmployeeAPI.GetStructure("EMPDATA").GetString("NATIONALITY")
            Dim COMPANY As String = EmployeeAPI.GetStructure("EMPDATA").GetString("COMPANY")
            Dim DEPARTMENT As String = EmployeeAPI.GetStructure("EMPDATA").GetString("DEPARTMENT")
            Dim JOINDATE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("JOINDATE")
            Dim IQAMAEXPIRY As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMAEXPIRY")
            Dim DIVISION As String = EmployeeAPI.GetStructure("EMPDATA").GetString("DIVISION")
            Dim RECTYPE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("RECTYPE")
            Dim EMAIL As String = EmployeeAPI.GetStructure("EMPDATA").GetString("EMAIL")
            Dim MGREMAIL As String = EmployeeAPI.GetStructure("EMPDATA").GetString("MGREMAIL")
            Dim IQAMAPROF_AR As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMAPROF_AR")
            Dim ENAME_AR As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ENAME_AR")
            Dim COSTCENTER As String = EmployeeAPI.GetStructure("EMPDATA").GetString("COSTCENTER")
            Dim PERAREA As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PERAREA")
            Dim PERSAREA As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PERSAREA")
            Dim NATIONALITY_AR As String = EmployeeAPI.GetStructure("EMPDATA").GetString("NATIONALITY_AR")
            Dim PASSPORT_NO As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PASSPORT_NO")
            Dim PASS_ISSUE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PASS_ISSUE")
            Dim PASS_EXP As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PASS_EXP")
            Dim ISU_PLACE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ISU_PLACE")
            Dim IQAMA_NO As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMA_NO")
            Dim IQAMA_ISSUE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMA_ISSUE")
            Dim IQAMA_PLACE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMA_PLACE")
            Dim ORG_UNIT As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ORG_UNIT")
            Dim PAYROLL_AREA As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PAYROLL_AREA")
            Dim PAY_METHOD As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PAY_METHOD")
            Dim BANK_NAME As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BANK_NAME")
            Dim BORDER_NO As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BORDER_NO")
            Dim BORDER_ISSUE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BORDER_ISSUE")
            Dim BORDER_EXP As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BORDER_EXP")
            Dim RELIGION As String = EmployeeAPI.GetStructure("EMPDATA").GetString("RELIGION")
            Dim MGR_NAME As String = EmployeeAPI.GetStructure("EMPDATA").GetString("MGR_NAME")
            Dim Special_Condition As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ZZSP_COND_TXT")
            Dim CHILDREN_NO As String = EmployeeAPI.GetStructure("EMPDATA").GetString("CHILDREN_NO")
            Dim SPOUSE_DATE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("SPOUSE_DATE")
            Dim LastWorkingDate As String = EmployeeAPI.GetStructure("EMPDATA").GetString("LWD")
            Dim EndOfContractDate As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ECD")
            Dim CompanyCode As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BUKRS")
            Dim CostCenterNumber As String = EmployeeAPI.GetStructure("EMPDATA").GetString("KOSTL")
            Dim dt As New DataTable("DataTable")
            dt.Columns.Add("FileNo", GetType(String))
            dt.Columns.Add("FullName", GetType(String))
            dt.Columns.Add("JobTitle", GetType(String))
            dt.Columns.Add("JobGrade", GetType(String))
            dt.Columns.Add("BASICSAL", GetType(String))
            dt.Columns.Add("NATIONALITY", GetType(String))
            dt.Columns.Add("COMPANY", GetType(String))
            dt.Columns.Add("DEPARTMENT", GetType(String))
            dt.Columns.Add("JOINDATE", GetType(String))
            dt.Columns.Add("IQAMAEXPIRY", GetType(String))
            dt.Columns.Add("DIVISION", GetType(String))
            dt.Columns.Add("RECTYPE", GetType(String))
            dt.Columns.Add("EMAIL", GetType(String))
            dt.Columns.Add("MGREMAIL", GetType(String))
            dt.Columns.Add("IQAMAPROF_AR", GetType(String))
            dt.Columns.Add("ENAME_AR", GetType(String))
            dt.Columns.Add("COSTCENTER", GetType(String))
            dt.Columns.Add("PERAREA", GetType(String))
            dt.Columns.Add("PERSAREA", GetType(String))
            dt.Columns.Add("NATIONALITY_AR", GetType(String))
            dt.Columns.Add("PASSPORT_NO", GetType(String))
            dt.Columns.Add("PASS_ISSUE", GetType(String))
            dt.Columns.Add("PASS_EXP", GetType(String))
            dt.Columns.Add("ISU_PLACE", GetType(String))
            dt.Columns.Add("IQAMA_NO", GetType(String))
            dt.Columns.Add("IQAMA_ISSUE", GetType(String))
            dt.Columns.Add("IQAMA_PLACE", GetType(String))
            dt.Columns.Add("ORG_UNIT", GetType(String))
            dt.Columns.Add("PAYROLL_AREA", GetType(String))
            dt.Columns.Add("PAY_METHOD", GetType(String))
            dt.Columns.Add("BANK_NAME", GetType(String))
            dt.Columns.Add("BORDER_NO", GetType(String))
            dt.Columns.Add("BORDER_ISSUE", GetType(String))
            dt.Columns.Add("BORDER_EXP", GetType(String))
            dt.Columns.Add("RELIGION", GetType(String))
            dt.Columns.Add("MGR_NAME", GetType(String))
            dt.Columns.Add("JoinDatePeriod", GetType(String))
            dt.Columns.Add("Special_Condition", GetType(String))
            dt.Columns.Add("CHILDREN_NO", GetType(String))
            dt.Columns.Add("SPOUSE_DATE", GetType(String))
            dt.Columns.Add("LastWorkingDate", GetType(String))
            dt.Columns.Add("EndOfContractDate", GetType(String))
            dt.Columns.Add("CompanyCodeNO", GetType(String))
            dt.Columns.Add("CostCenterNo", GetType(String))
            'Dim DR As DataRow = dt.NewRow()
            'DR("FileNo") = FileNo
            'DR("FullName") = FullName
            'DR("JobTitle") = JobTitle
            'DR("JobGrade") = JobGrade
            'DR("BASICSAL") = BASICSAL
            'DR("NATIONALITY") = NATIONALITY
            'DR("COMPANY") = COMPANY
            'DR("DEPARTMENT") = DEPARTMENT
            'DR("JOINDATE") = JOINDATE
            'DR("IQAMAEXPIRY") = IQAMAEXPIRY
            'DR("DIVISION") = DIVISION
            'DR("RECTYPE") = RECTYPE
            'DR("EMAIL") = EMAIL
            'DR("MGREMAIL") = MGREMAIL
            'DR("IQAMAPROF_AR") = IQAMAPROF_AR
            'DR("ENAME_AR") = ENAME_AR
            'DR("COSTCENTER") = COSTCENTER
            'DR("PERAREA") = PERAREA
            'DR("PERSAREA") = PERSAREA
            'DR("NATIONALITY_AR") = NATIONALITY_AR
            'DR("PASSPORT_NO") = PASSPORT_NO
            'DR("PASS_ISSUE") = PASS_ISSUE
            'DR("PASS_EXP") = PASS_EXP
            'DR("ISU_PLACE") = ISU_PLACE
            'DR("IQAMA_NO") = IQAMA_NO
            'DR("IQAMA_ISSUE") = IQAMA_ISSUE
            'DR("IQAMA_PLACE") = IQAMA_PLACE
            'DR("ORG_UNIT") = ORG_UNIT
            'DR("PAYROLL_AREA") = PAYROLL_AREA
            'DR("PAY_METHOD") = PAY_METHOD
            'DR("BANK_NAME") = BANK_NAME
            'DR("BORDER_NO") = BORDER_NO
            'DR("BORDER_ISSUE") = BORDER_ISSUE
            'DR("BORDER_EXP") = BORDER_EXP
            'DR("RELIGION") = RELIGION
            'DR("MGR_NAME") = MGR_NAME
            'DR("JoinDatePeriod") = JoinDatePeriod(JOINDATE)
            'DR("Special_Condition") = Special_Condition
            'DR("CHILDREN_NO") = CHILDREN_NO
            'DR("SPOUSE_DATE") = SPOUSE_DATE
            'DR("LastWorkingDate") = LastWorkingDate
            'DR("EndOfContractDate") = EndOfContractDate
            'DR("CompanyCodeNO") = CompanyCode
            'DR("CostCenterNo") = CostCenterNumber



            dt.Rows.Add(FileNo.ToString(),
                        FullName.ToString(), JobTitle.ToString(), JobGrade.ToString(), BASICSAL.ToString(),
                        NATIONALITY.ToString(), COMPANY.ToString(), DEPARTMENT.ToString(), JOINDATE.ToString(),
                       IQAMAEXPIRY.ToString(), DIVISION.ToString(), RECTYPE.ToString(), EMAIL.ToString(),
                     MGREMAIL.ToString().Trim().ToLower(), IQAMAPROF_AR.ToString(), ENAME_AR.ToString(), COSTCENTER.ToString(),
                    PERAREA.ToString(), PERSAREA.ToString(), NATIONALITY_AR.ToString(), PASSPORT_NO.ToString(),
                    PASS_ISSUE.ToString(), PASS_EXP.ToString(), ISU_PLACE.ToString(), IQAMA_NO.ToString(),
                    IQAMA_ISSUE.ToString(), IQAMA_PLACE.ToString(), ORG_UNIT.ToString(), PAYROLL_AREA.ToString(),
                    PAY_METHOD.ToString(), BANK_NAME.ToString(), BORDER_NO.ToString(), BORDER_ISSUE.ToString(),
                    BORDER_EXP.ToString(), RELIGION.ToString(), MGR_NAME.ToString(), JoinDatePeriod(JOINDATE),
                   Special_Condition.ToString(), CHILDREN_NO.ToString(), SPOUSE_DATE.ToString(),
                   LastWorkingDate, EndOfContractDate, CompanyCode, CostCenterNumber
                )
            '  dt.Rows.Add(DR)
            Dim ds As New DataSet("DataSet")
            ds.Tables.Add(dt)
            Return ds
        '  Catch ex As Exception
        '  Throw ex
        '   End Try


        'Return Values

    End Function

    <WebMethod()> _
    Public Function GetEmpDataByLoginName(ByVal LoginName As String) As DataSet
        On Error Resume Next
        If LoginName = "" Then

            LoginName = "0000"

        End If

        'LoginName = "Usman.ali"

        LoginName = LoginName.Replace("i:0#.w|alfanar\", "")
        LoginName = LoginName.Replace("i:0#.w|", "")
        LoginName = LoginName.Replace("alfanar\", "")

        Dim strName As String
        Dim dirEntry As System.DirectoryServices.DirectoryEntry
        Dim dirSearcher As System.DirectoryServices.DirectorySearcher
        ' m_LoginName = System.Environment.UserName.ToString 'The logged in user ID 
        dirEntry = New System.DirectoryServices.DirectoryEntry("LDAP://alfanar.com", "SPSyncAD", "s@p159753")
        dirSearcher = New System.DirectoryServices.DirectorySearcher(dirEntry)
        dirSearcher.Filter = "(samAccountName=" & LoginName & ")"
        'Use the .FindOne() Method to stop as soon as a match is found 

        Dim sr As SearchResult = dirSearcher.FindOne()

        If sr Is Nothing Then

            strName = "0000"

        End If

        On Error Resume Next
        Dim de As System.DirectoryServices.DirectoryEntry = sr.GetDirectoryEntry()

        strName = de.Properties("description").Value.ToString()

        On Error Resume Next
        RfcDestinationManager.RegisterDestinationConfiguration(New NetConnection.ECCDestinationConfig)

        my_ecc = RfcDestinationManager.GetDestination("ECDCLNT140")


        Dim EmployeeAPI As IRfcFunction = my_ecc.Repository.CreateFunction("ZBAPI_GETEMPLOYEE")
        EmployeeAPI.SetValue("PERSNO", strName)

        EmployeeAPI.Invoke(my_ecc)
        Dim Fileno As String = strName
        Dim FullName As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ENAME")
        Dim JobTitle As String = EmployeeAPI.GetStructure("EMPDATA").GetString("JOBTITLE")
        Dim JobGrade As String = EmployeeAPI.GetStructure("EMPDATA").GetString("JOBGRADE")
        Dim BASICSAL As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BASICSAL")
        Dim NATIONALITY As String = EmployeeAPI.GetStructure("EMPDATA").GetString("NATIONALITY")
        Dim COMPANY As String = EmployeeAPI.GetStructure("EMPDATA").GetString("COMPANY")
        Dim DEPARTMENT As String = EmployeeAPI.GetStructure("EMPDATA").GetString("DEPARTMENT")
        Dim JOINDATE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("JOINDATE")
        Dim IQAMAEXPIRY As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMAEXPIRY")
        Dim DIVISION As String = EmployeeAPI.GetStructure("EMPDATA").GetString("DIVISION")
        Dim RECTYPE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("RECTYPE")
        Dim EMAIL As String = EmployeeAPI.GetStructure("EMPDATA").GetString("EMAIL")
        Dim MGREMAIL As String = EmployeeAPI.GetStructure("EMPDATA").GetString("MGREMAIL")
        Dim IQAMAPROF_AR As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMAPROF_AR")
        Dim ENAME_AR As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ENAME_AR")
        Dim COSTCENTER As String = EmployeeAPI.GetStructure("EMPDATA").GetString("COSTCENTER")
        Dim PERAREA As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PERAREA")
        Dim PERSAREA As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PERSAREA")
        Dim NATIONALITY_AR As String = EmployeeAPI.GetStructure("EMPDATA").GetString("NATIONALITY_AR")
        Dim PASSPORT_NO As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PASSPORT_NO")
        Dim PASS_ISSUE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PASS_ISSUE")
        Dim PASS_EXP As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PASS_EXP")
        Dim ISU_PLACE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ISU_PLACE")
        Dim IQAMA_NO As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMA_NO")
        Dim IQAMA_ISSUE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMA_ISSUE")
        Dim IQAMA_PLACE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMA_PLACE")
        Dim ORG_UNIT As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ORG_UNIT")
        Dim PAYROLL_AREA As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PAYROLL_AREA")
        Dim PAY_METHOD As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PAY_METHOD")
        Dim BANK_NAME As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BANK_NAME")
        Dim BORDER_NO As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BORDER_NO")
        Dim BORDER_ISSUE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BORDER_ISSUE")
        Dim BORDER_EXP As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BORDER_EXP")
        Dim RELIGION As String = EmployeeAPI.GetStructure("EMPDATA").GetString("RELIGION")
        Dim MGR_NAME As String = EmployeeAPI.GetStructure("EMPDATA").GetString("MGR_NAME")
        Dim Special_Condition As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ZZSP_COND_TXT")
        Dim CHILDREN_NO As String = EmployeeAPI.GetStructure("EMPDATA").GetString("CHILDREN_NO")
        Dim SPOUSE_DATE As String = EmployeeAPI.GetStructure("EMPDATA").GetString("SPOUSE_DATE")
        Dim LastWorkingDate As String = EmployeeAPI.GetStructure("EMPDATA").GetString("LWD")
        Dim EndOfContractDate As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ECD")
        Dim CompanyCode As String = EmployeeAPI.GetStructure("EMPDATA").GetString("BUKRS")
        Dim CostCenterNumber As String = EmployeeAPI.GetStructure("EMPDATA").GetString("KOSTL")

        Dim dt As New DataTable("DataTable")
        dt.Columns.Add("FileNo", GetType(String))
        dt.Columns.Add("FullName", GetType(String))
        dt.Columns.Add("JobTitle", GetType(String))
        dt.Columns.Add("JobGrade", GetType(String))
        dt.Columns.Add("BASICSAL", GetType(String))
        dt.Columns.Add("NATIONALITY", GetType(String))
        dt.Columns.Add("COMPANY", GetType(String))
        dt.Columns.Add("DEPARTMENT", GetType(String))
        dt.Columns.Add("JOINDATE", GetType(String))
        dt.Columns.Add("IQAMAEXPIRY", GetType(String))
        dt.Columns.Add("DIVISION", GetType(String))
        dt.Columns.Add("RECTYPE", GetType(String))
        dt.Columns.Add("EMAIL", GetType(String))
        dt.Columns.Add("MGREMAIL", GetType(String))
        dt.Columns.Add("IQAMAPROF_AR", GetType(String))
        dt.Columns.Add("ENAME_AR", GetType(String))
        dt.Columns.Add("COSTCENTER", GetType(String))
        dt.Columns.Add("PERAREA", GetType(String))
        dt.Columns.Add("PERSAREA", GetType(String))
        dt.Columns.Add("NATIONALITY_AR", GetType(String))
        dt.Columns.Add("PASSPORT_NO", GetType(String))
        dt.Columns.Add("PASS_ISSUE", GetType(String))
        dt.Columns.Add("PASS_EXP", GetType(String))
        dt.Columns.Add("ISU_PLACE", GetType(String))
        dt.Columns.Add("IQAMA_NO", GetType(String))
        dt.Columns.Add("IQAMA_ISSUE", GetType(String))
        dt.Columns.Add("IQAMA_PLACE", GetType(String))
        dt.Columns.Add("ORG_UNIT", GetType(String))
        dt.Columns.Add("PAYROLL_AREA", GetType(String))
        dt.Columns.Add("PAY_METHOD", GetType(String))
        dt.Columns.Add("BANK_NAME", GetType(String))
        dt.Columns.Add("BORDER_NO", GetType(String))
        dt.Columns.Add("BORDER_ISSUE", GetType(String))
        dt.Columns.Add("BORDER_EXP", GetType(String))
        dt.Columns.Add("RELIGION", GetType(String))
        dt.Columns.Add("MGR_NAME", GetType(String))
        dt.Columns.Add("JoinDatePeriod", GetType(String))
        dt.Columns.Add("Special_Condition", GetType(String))
        dt.Columns.Add("CHILDREN_NO", GetType(String))
        dt.Columns.Add("SPOUSE_DATE", GetType(String))

        dt.Columns.Add("LastWorkingDate", GetType(String))
        dt.Columns.Add("EndOfContractDate", GetType(String))
        dt.Columns.Add("CompanyCodeNO", GetType(String))
        dt.Columns.Add("CostCenterNo", GetType(String))

        dt.Rows.Add(Fileno.ToString(),
                    FullName.ToString(), JobTitle.ToString(), JobGrade.ToString(), BASICSAL.ToString(),
                    NATIONALITY.ToString(), COMPANY.ToString(), DEPARTMENT.ToString(), JOINDATE.ToString(),
                   IQAMAEXPIRY.ToString(), DIVISION.ToString(), RECTYPE.ToString(), EMAIL.ToString(),
                 MGREMAIL.ToString().Trim().ToLower(), IQAMAPROF_AR.ToString(), ENAME_AR.ToString(), COSTCENTER.ToString(),
                PERAREA.ToString(), PERSAREA.ToString(), NATIONALITY_AR.ToString(), PASSPORT_NO.ToString(),
                PASS_ISSUE.ToString(), PASS_EXP.ToString(), ISU_PLACE.ToString(), IQAMA_NO.ToString(),
                IQAMA_ISSUE.ToString(), IQAMA_PLACE.ToString(), ORG_UNIT.ToString(), PAYROLL_AREA.ToString(),
                PAY_METHOD.ToString(), BANK_NAME.ToString(), BORDER_NO.ToString(), BORDER_ISSUE.ToString(),
                BORDER_EXP.ToString(), RELIGION.ToString(), MGR_NAME.ToString(), JoinDatePeriod(JOINDATE), Special_Condition.ToString(), CHILDREN_NO.ToString(), SPOUSE_DATE.ToString(), LastWorkingDate, EndOfContractDate, CompanyCode, CostCenterNumber)

        Dim ds As New DataSet("DataSet")
        ds.Tables.Add(dt)
        Return ds



    End Function


    <WebMethod()>
    Public Function Test(ByVal x As String) As String

        Return x
    End Function
    <WebMethod()> _
    Public Function GetEmpDataByFileNo2(ByVal FileNo As String) As DataSet



        On Error Resume Next

        On Error Resume Next

        RfcDestinationManager.RegisterDestinationConfiguration(New NetConnection.ECCDestinationConfig)

        my_ecc = RfcDestinationManager.GetDestination("ECDCLNT140")


        Dim EmployeeAPI As IRfcFunction = my_ecc.Repository.CreateFunction("ZBAPI_GETEMPLOYEE")
        EmployeeAPI.SetValue("PERSNO", FileNo)

        TranslateArabic(FileNo)

        EmployeeAPI.Invoke(my_ecc)
        Dim EnglishFileNo As String = FileNo
        Dim ArabicFileNo As String = strVal
        Dim EnglishName As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ENAME")
        Dim ArabicName As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ENAME_AR")
        Dim OrgUnitEn As String = EmployeeAPI.GetStructure("EMPDATA").GetString("ORG_UNIT")
        Dim OrgUnitAr As String = OrgUnitEn
        Dim CoEnglish As String = EmployeeAPI.GetStructure("EMPDATA").GetString("COMPANY")
        Dim CoArabic As String = CoEnglish
        Dim NationalityEn As String = EmployeeAPI.GetStructure("EMPDATA").GetString("NATIONALITY")
        Dim NationalityAr As String = EmployeeAPI.GetStructure("EMPDATA").GetString("NATIONALITY_AR")
        Dim JoinDateEn As String = EmployeeAPI.GetStructure("EMPDATA").GetString("JOINDATE")
        TranslateArabic(JoinDateEn)
        Dim JoinDateAr As String = strVal
        Dim PassportNoEn As String = EmployeeAPI.GetStructure("EMPDATA").GetString("PASSPORT_NO")
        TranslateArabic(PassportNoEn)
        Dim PassportNoAr As String = strVal
        Dim IDNoEn As String = EmployeeAPI.GetStructure("EMPDATA").GetString("IQAMA_NO")
        TranslateArabic(IDNoEn)
        Dim IDNoAr As String = strVal

        Dim ProfessionAR As String = EmployeeAPI.GetStructure("EMPDATA").GetString("JOBTITLE")
        Dim ProfessionEn As String = ProfessionAR

        Dim dt As New DataTable("DataTable")
        dt.Columns.Add("EnglishFileNo", GetType(String))
        dt.Columns.Add("ArabicFileNo", GetType(String))

        dt.Columns.Add("EnglishName", GetType(String))
        dt.Columns.Add("ArabicName", GetType(String))

        dt.Columns.Add("OrgUnitEn", GetType(String))
        dt.Columns.Add("OrgUnitAr", GetType(String))

        dt.Columns.Add("CoEnglish", GetType(String))
        dt.Columns.Add("CoArabic", GetType(String))

        dt.Columns.Add("NationalityEn", GetType(String))
        dt.Columns.Add("NationalityAr", GetType(String))

        dt.Columns.Add("JoinDateEn", GetType(String))
        dt.Columns.Add("JoinDateAr", GetType(String))

        dt.Columns.Add("PassportNoEn", GetType(String))
        dt.Columns.Add("PassportNoAr", GetType(String))

        dt.Columns.Add("IDNoEn", GetType(String))
        dt.Columns.Add("IDNoAr", GetType(String))

        dt.Columns.Add("ProfessionAR", GetType(String))
        dt.Columns.Add("ProfessionEn", GetType(String))

        dt.Rows.Add(EnglishFileNo.ToString(), ArabicFileNo.ToString(),
                  EnglishName.ToString(), ArabicName.ToString(),
 OrgUnitEn.ToString(), OrgUnitAr.ToString(), CoEnglish.ToString(), CoArabic.ToString(), NationalityEn.ToString(), NationalityAr.ToString(),
         JoinDateEn.ToString(), JoinDateAr.ToString(), PassportNoEn.ToString(), PassportNoAr.ToString(),
         IDNoEn.ToString(), IDNoAr.ToString(), ProfessionAR.ToString(), ProfessionEn.ToString())

        Dim ds As New DataSet("DataSet")
        ds.Tables.Add(dt)
        Return ds



    End Function

    <WebMethod()> _
    Public Function GetGradeByFileNo(ByVal FileNo As String, ByVal DesiredGrade As String) As DataSet

        On Error Resume Next

        On Error Resume Next



        RfcDestinationManager.RegisterDestinationConfiguration(New NetConnection.ECCDestinationConfig)

        my_ecc = RfcDestinationManager.GetDestination("ECDCLNT140")


        Dim EmployeeAPI As IRfcFunction = my_ecc.Repository.CreateFunction("Z_GETMGR_GROUPBASED_MOBILE")
        EmployeeAPI.SetValue("FILE", FileNo)
        EmployeeAPI.SetValue("GROUP", DesiredGrade)



        EmployeeAPI.Invoke(my_ecc)
        Dim Grade As String = EmployeeAPI.GetString("MGR_GROUP")
        Dim GradeFileNo As Integer = EmployeeAPI.GetString("MGRFILE")
        Dim EmpDataDs As DataSet = GetEmployeeDataByFileNo(GradeFileNo)
        Dim Email As String = EmpDataDs.Tables(0).Rows(0)("EMAIL").ToString()
        Dim OldEmail As String = EmpDataDs.Tables(0).Rows(0)("EMAIL").ToString()
        Dim FullName As String = EmpDataDs.Tables(0).Rows(0)("FULLNAME").ToString()
        Dim dt As New DataTable("DataTable")
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("FileNo", GetType(String))
        dt.Columns.Add("Grade", GetType(String))
        'Replace Email If Needed
        Dim B3DS As DataSet
        Email = Email.ToString().Trim().ToLower()
        If OldEmail <> Email Then
            B3DS = GetEmpDataByLoginName(Email.ToLower().Replace("@alfanar.com", String.Empty))
            If Not IsNothing(B3DS) AndAlso B3DS.Tables.Count > 0 AndAlso B3DS.Tables(0).Rows.Count > 0 Then
                FullName = B3DS.Tables(0).Rows(0)("FullName")
                GradeFileNo = B3DS.Tables(0).Rows(0)("FileNo")
                Grade = B3DS.Tables(0).Rows(0)("JobGrade")
            End If
        End If
        dt.Rows.Add(Email.ToString(), FullName, GradeFileNo, Grade)
        Dim ds As New DataSet("DataSet")
        ds.Tables.Add(dt)
        Return ds




    End Function


    <WebMethod()> _
    Public Function GetGradeByLoginName(ByVal LoginName As String, ByVal DesiredGrade As String) As DataSet



        If LoginName = "" Then

            LoginName = "0000"

        End If

        LoginName = LoginName.Replace("i:0#.w|alfanar\", "")
        LoginName = LoginName.Replace("i:0#.w|", "")
        LoginName = LoginName.Replace("alfanar\", "")

        Dim strName As String
        Dim dirEntry As System.DirectoryServices.DirectoryEntry
        Dim dirSearcher As System.DirectoryServices.DirectorySearcher
        ' m_LoginName = System.Environment.UserName.ToString 'The logged in user ID 
        dirEntry = New System.DirectoryServices.DirectoryEntry("LDAP://alfanar.com", "SPSyncAD", "s@p159753")
        dirSearcher = New System.DirectoryServices.DirectorySearcher(dirEntry)
        dirSearcher.Filter = "(samAccountName=" & LoginName & ")"
        'Use the .FindOne() Method to stop as soon as a match is found 

        Dim sr As SearchResult = dirSearcher.FindOne()

        If sr Is Nothing Then

            strName = "0000"

        End If

        On Error Resume Next
        Dim de As System.DirectoryServices.DirectoryEntry = sr.GetDirectoryEntry()

        strName = de.Properties("description").Value.ToString()

        On Error Resume Next
        RfcDestinationManager.RegisterDestinationConfiguration(New NetConnection.ECCDestinationConfig)

        my_ecc = RfcDestinationManager.GetDestination("ECDCLNT140")
        Dim EmployeeAPI As IRfcFunction = my_ecc.Repository.CreateFunction("ZBAPI_GET_APPR_CVR")
        EmployeeAPI.SetValue("PERSNO", strName)
        EmployeeAPI.SetValue("GRADE", DesiredGrade)


        EmployeeAPI.Invoke(my_ecc)

        Dim Rowcount As Integer = EmployeeAPI.GetTable("APPRDATA").RowCount

        For i = 0 To Rowcount

            Dim Grade As String = EmployeeAPI.GetTable("APPRDATA").Item(i).GetString("Grade")
            Dim Persno As String = EmployeeAPI.GetTable("APPRDATA").Item(i).GetString("PERSNO")
            Dim Email As String = EmployeeAPI.GetTable("APPRDATA").Item(i).GetString("EMAIL")


            If (Grade = DesiredGrade) And (Email <> "Null") Then

                Dim dt As New DataTable("DataTable")
                dt.Columns.Add("Email", GetType(String))
                dt.Columns.Add("Name", GetType(String))
                'Replace Email If Needed
                Email = Email.ToString().Trim().ToLower()
                dt.Rows.Add(Email.ToString(), GetEmpNameByLoginName(Email.ToString()))

                Dim ds As New DataSet("DataSet")
                ds.Tables.Add(dt)
                Return ds

            ElseIf (Grade <> DesiredGrade) Or (Email <> "Null") Then


                Dim dt As New DataTable("DataTable")
                dt.Columns.Add("Email", GetType(String))
                dt.Columns.Add("Name", GetType(String))
                'Replace Email If Needed
                Email = Email.ToString().Trim().ToLower()
                dt.Rows.Add(Email.ToString(), GetEmpNameByLoginName(Email.ToString()))

                Dim ds As New DataSet("DataSet")
                ds.Tables.Add(dt)
                Return ds


            End If
        Next i


    End Function

    Private Function GetEmpNameByLoginName(ByVal LoginName As String) As String

        If LoginName = "" Then

            LoginName = "0000"

        End If

        LoginName = LoginName.Replace("i:0#.w|alfanar\", "")
        LoginName = LoginName.Replace("i:0#.w|", "")
        LoginName = LoginName.Replace("alfanar\", "")

        Dim UserName As String() = LoginName.Split(New Char() {"@"c})
        LoginName = UserName(0).ToString()

        Dim strName As String
        Dim dirEntry As System.DirectoryServices.DirectoryEntry
        Dim dirSearcher As System.DirectoryServices.DirectorySearcher
        ' m_LoginName = System.Environment.UserName.ToString 'The logged in user ID 
        dirEntry = New System.DirectoryServices.DirectoryEntry("LDAP://alfanar.com", "SPSyncAD", "s@p159753")
        dirSearcher = New System.DirectoryServices.DirectorySearcher(dirEntry)
        dirSearcher.Filter = "(samAccountName=" & LoginName & ")"
        'Use the .FindOne() Method to stop as soon as a match is found 

        Dim sr As SearchResult = dirSearcher.FindOne()

        If sr Is Nothing Then

            strName = "0000"

        End If

        On Error Resume Next
        Dim de As System.DirectoryServices.DirectoryEntry = sr.GetDirectoryEntry()

        strName = de.Properties("displayName").Value.ToString()

        Return strName

    End Function

    Function JoinDatePeriod(ByVal jdate As String) As String
        If (String.IsNullOrEmpty(jdate)) Then
            Return "0"
        End If
        Dim a As String
        a = DateDiff(DateInterval.Day, CDate(jdate), CDate(Date.Now.ToString()))
        Return a
    End Function

    Function TranslateArabic(ByVal sIn As String) As String

        Dim enc As New System.Text.UTF8Encoding
        Dim utf8Decoder As System.Text.Decoder
        utf8Decoder = enc.GetDecoder
        Dim sTranslated = New System.Text.StringBuilder
        Dim cTransChar(1) As Char
        Dim bytes() As Byte = {217, 160}
        Dim aChars() As Char = sIn.ToCharArray
        For Each c As Char In aChars
            If Char.IsDigit(c) Then
                bytes(1) = 160 + CInt(Char.GetNumericValue(c))
                utf8Decoder.GetChars(bytes, 0, 2, cTransChar, 0)
                sTranslated.Append(cTransChar(0))
            Else
                sTranslated.Append(c)
            End If
        Next
        TranslateArabic = sTranslated.ToString
        strVal = TranslateArabic
    End Function
    

End Class