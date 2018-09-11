<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminstockin.aspx.cs" Inherits="ejcloset.adminstockin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="content">
        <div class="container-fluid">
            <!-- Title -->
            <div class="block-header">
                <h1>STOCK IN</h1>
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
                                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                        <asp:UpdatePanel ID="updt1" runat="server">
                                            <ContentTemplate>
                                <label for="item_code">Item Code <label style="color:red">*</label></label>
                                <div class="form-group">
                                    <div class="form-line">
                                        
                                                <asp:TextBox ID="txt_item_code" runat="server" class="form-control" placeholder="Enter item's barcode" AutoPostBack="true" OnTextChanged="txt_item_code_textchanged" required=""></asp:TextBox>
                                            

                                    </div>
                                </div>
                                <label for="item_title">Title</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="txt_item_title" runat="server" class="form-control" disabled="">
                                    </div>
                                </div>
                                <label for="item_price">Price</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="txt_item_price" runat="server" class="form-control" disabled="">
                                    </div>
                                </div>
                                

                                <label for="item_category">Category</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="txt_item_category" runat="server"  class="form-control" disabled="">
                                    </div>
                                </div>

                               

                                <label for="item_supplier">Supplier</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        
                                        <input type="text" id="txt_item_supplier" runat="server" class="form-control" disabled="">
                                    </div>
                                </div>

                                <label for="item_exisiting_quantity">Existing Quantity</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="txt_item_existing_quantity" runat="server" class="form-control" disabled="">
                                    </div>
                                </div>

                                <label for="item_quantity">Stock In Quantity <label style="color:red">*</label></label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="number" id="txt_item_quantity" runat="server" class="form-control" required="">
                                    </div>
                                </div>

                                                </ContentTemplate>
                                        </asp:UpdatePanel>

                                

                                <div style="text-align:right">
                                    <asp:button class="btn btn-warning waves-effect"  formnovalidate="" runat="server" OnClick="btn_clear_click" Text="CLEAR" />
                                <asp:button class="btn btn-primary waves-effect" style="margin-left:10px" runat="server" OnClick="btn_stockin_click" data-type="basic" type="submit" Text="STOCK IN"/>

                                </div>


                               
                            </form>
                        </div>

            <!-- #END# Input -->
            </div>
            </div>
            </div>
            </div>
     </section>

    <script> 
        //Functions to open database and to create, insert data into tables

        getSelectedRow = function (val) {
            db.transaction(function (transaction) {
                transaction.executeSql('SELECT * FROM Employ where number = ?;', [parseInt(val)], selectedRowValues, errorHandler);

            });
        };
        selectedRowValues = function (transaction, results) {
            for (var i = 0; i < results.rows.length; i++) {
                var row = results.rows.item(i);
                alert(row['number']);
                alert(row['name']);
            }
        };
</script>

</asp:Content>
