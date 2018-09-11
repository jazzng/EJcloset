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

                        <div class="body" style="padding-bottom:100px">
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
<<<<<<< HEAD
                                            </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
=======
>>>>>>> 8506b84db579497df51b8fc345e36266136ac7e5


>>>>>>> 598208c64e16e32a261818da92e177d3789d1654

                                        <div class="col-lg-4 col-md-4 col-sm-6 col-xs-12" style="margin-top: 20px">
                                            <div class="card">
                                                <div class="body bg-white">


                                                        <table class="nav-justified">
                                                            <tr>
                                                                <td style="width: 70px"><label for="subtotal">Subtotal</label></td>
                                                                <td class="noUi-vertical" style="width: 5px"><label>:</label></td>
                                                                <td><label id="lbl_subtotal"></label></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 70px"><label for="tax">Tax</label></td>
                                                                <td class="noUi-vertical" style="width: 5px"><label>:</label></td>
                                                                <td><label id="lbl_tax"></label></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 70px"><label for="due">Due</label></td>
                                                                <td class="noUi-vertical" style="width: 5px"><label>:</label></td>
                                                                <td><label id="lbl_due"></label></td>
                                                            </tr>
                                                        </table>

                                                </div>
                                            </div>
                                        </div>


                                        <div style="text-align:right; margin-top:20px; margin-right:15px">
                                    <asp:Button class="btn btn-warning waves-effect" formnovalidate="" runat="server" Text="CLEAR" />
                                    <asp:Button class="btn btn-primary waves-effect" Style="margin-left: 10px" runat="server" data-type="basic" type="submit" Text="STOCK IN" />

                                    </div>

                                

                                </ContentTemplate>
                                </asp:UpdatePanel>



                            </form>
                        </div>

                        <!-- #END# Input -->
                    </d>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
