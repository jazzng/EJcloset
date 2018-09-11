<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminpayment.aspx.cs" Inherits="ejcloset.adminpayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section class="content">
        <div class="container-fluid">
            <!-- Title -->
            <div class="block-header">
                <h1>PAYMENT</h1>
            </div>

            <!-- Input -->
            <div class="row clearfix">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="card">
                        <div class="header">
                            <h2>Add Quantity of Current Stock</h2>

                            <!-- Top right corner function list -->
                            <%--<ul class="header-dropdown m-r--5">
                                <li class="dropdown">
                                    <a href="javascript:void(0);" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                                        <i class="material-icons">more_vert</i>
                                    </a>
                                    <ul class="dropdown-menu pull-right">
                                        <li><a href="javascript:void(0);">Action</a></li>
                                        <li><a href="javascript:void(0);">Another action</a></li>
                                        <li><a href="javascript:void(0);">Something else here</a></li>
                                    </ul>
                                </li>
                            </ul>--%>
                            </div>

                        <div class="body">
                            <form>
                                <label for="item_title">Payment ID:</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="txt_item_title" runat="server" class="form-control" disabled="">
                                    </div>
                                </div>
                                <label for="item_price">Issued By:</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="txt_item_price" runat="server" class="form-control" disabled="">
                                    </div>
                                </div>
                                

                                <label for="item_category">Date:</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="txt_item_category" runat="server"  class="form-control" disabled="">
                                    </div>
                                </div>                               

                                <label for="item_supplier">Item Code:</label>
                                <div class="form-group">
                                    <div class="form-line">                                        
                                        <input type="text" id="txt_item_supplier" runat="server" class="form-control" disabled="">
                                    </div>
                                </div>




                                                </ContentTemplate>
                                        </asp:UpdatePanel>

                                

                                <div style="text-align:right">
                                    <asp:button class="btn btn-warning waves-effect"  formnovalidate="" runat="server" Text="CLEAR" />
                                <asp:button class="btn btn-primary waves-effect" style="margin-left:10px" runat="server" data-type="basic" type="submit" Text="STOCK IN"/>

                                </div>


                               
                            </form>
                        </div>

            <!-- #END# Input -->
            </div>
            </div>
            </div>
            </div>
     </section>
</asp:Content>
