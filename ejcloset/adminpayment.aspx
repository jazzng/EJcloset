<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminpayment.aspx.cs" Inherits="ejcloset.adminpayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">
        <div class="container-fluid">

            <!-- Input -->
            <div class="row clearfix">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="card">
                        <div class="header">
                            <div class="col-sm-4">
                                    <label for="payment_id">Payment ID: </label>
                                <label for="payment_id" id="lbl_paymentid" runat="server"></label>
                                </div>

                                <div class="col-sm-4">
                                    <label for="issued_by">Issued By: </label>
                                     <label for="issued_by" id="lbl_issuedby" runat="server"></label>
                                </div>

                                <div class="col-sm-4">
                                    <label for="date">Date: </label>
                                     <label for="date" id="lbl_date" runat="server"></label>
                                </div>

                           
                        </div>

                        <div class="body">
                            <form>

                                <div class="col-sm-4">
                                    <label for="item_code">Item Code:</label>
                                    <div class="form-group">
                                        <div class="form-line focused">
                                            <asp:TextBox ID="txt_itemcode" runat="server" class="form-control" placeholder="Enter Item's Barcode" AutoPostBack="true" OnTextChanged="txt_itemcode_textchanged"></asp:TextBox>

                                        </div>
                                    </div>
                                </div>

                                <%-- Editable Table --%>
                                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                <asp:UpdatePanel ID="updt1" runat="server">
                                    <ContentTemplate>
                                        <div class="body">
                                        <table id="example" class="table table-striped" style="width: 100%">
                                            <thead>
                                                <tr>
                                                    <th>No</th>
                                                    <th>Item Code</th>
                                                    <th>Title</th>
                                                    <th>Price</th>
                                                    <th>Quantity</th>
                                                    <th>Discount%</th>
                                                    <th>FOC</th>
                                                    <th>Subtotal</th>
                                                    <th>Delete</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>Tiger Nixon</td>
                                                    <td>Tiger Nixon</td>
                                                    <td>Tiger Nixon</td>
                                                    <td><input type="text" id="row-1-position" name="row-1-position" value="System Architect"></td>
                                                    <td><input type="text" id="row-1-position" name="row-1-position" value="System Architect"></td>
                                                    <td><input type="text" id="row-1-position" name="row-1-position" value="System Architect"></td>
                                                    <td><input type="checkbox" id="checkbox" name="checkbox" style="padding-top:20px"><label for="checkbox"></label></td>
                                                    <td>Tiger Nixon</td>
                                                    <td><button type="button" class="btn btn-danger btn-xs dt-delete">
					<span class="glyphicon glyphicon-remove" aria-hidden="true"></span>
				</button></td>                                                 
                                                </tr> 
                                                <tr>
                                                    <td>Tiger Nixon</td>
                                                    <td>Tiger Nixon</td>
                                                    <td>Tiger Nixon</td>
                                                    <td><input type="text" id="row-1-position" name="row-1-position" value="System Architect"></td>
                                                    <td><input type="text" id="row-1-position" name="row-1-position" value="System Architect"></td>
                                                    <td><input type="text" id="row-1-position" name="row-1-position" value="System Architect"></td>
                                                    <td><input type="checkbox" id="checkbox1" name="checkbox" style="padding-top:20px"><label for="checkbox1"></label></td>
                                                    <td>Tiger Nixon</td>
                                                    <td>Delete</td>                                                 
                                                </tr>
                                        </table>
                                            </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>



                                <div style="text-align: right">
                                    <asp:Button class="btn btn-warning waves-effect" formnovalidate="" runat="server" Text="CLEAR" />
                                    <asp:Button class="btn btn-primary waves-effect" Style="margin-left: 10px" runat="server" data-type="basic" type="submit" Text="STOCK IN" />

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
