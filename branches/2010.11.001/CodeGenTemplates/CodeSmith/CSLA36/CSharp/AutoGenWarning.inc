<% if(objInfo.IsGeneratedClass && !objInfo.IsSingle) {%>
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.6 CodeSmith Template Collection.
//     Changes to this file may be lost if the code is regenerated.
//     Modify user class <%=objInfo.CustomName%>.cs to extend this generated code. 
//
//     Code was generated at <%=DateTime.Now.ToString()%> by <%=Environment.UserName%>
//     Template path: <%=CodeTemplateInfo.FullPath%>
//     Template website: http://www.codeplex.com/CSLAcontrib
// </autogenerated>
//------------------------------------------------------------------------------
<% } %>