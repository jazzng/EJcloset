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
                                <label for="item_code">Item Code <label style="color:red">*</label></label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="item_code" class="form-control" placeholder="Enter item's barcode" required="">
                                    </div>
                                </div>
                                <label for="item_title">Title</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="item_title" class="form-control" disabled="">
                                    </div>
                                </div>
                                <label for="item_price">Price</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="item_price" class="form-control" disabled="">
                                    </div>
                                </div>
                                

                                <label for="item_category">Category</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="item_category" class="form-control" disabled="">
                                    </div>
                                </div>

                               

                                <label for="item_supplier">Supplier</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        
                                        <input type="text" id="item_supplier" class="form-control" disabled="">
                                    </div>
                                </div>
                                <label for="item_quantity">Stock In Quantity <label style="color:red">*</label></label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="number" id="item_quantity" class="form-control" required="">
                                    </div>
                                </div>

                                <div style="text-align:right">
                                    <button class="btn btn-warning waves-effect"  type="reset"> CLEAR </button>
                                <button class="btn btn-primary waves-effect" style="margin-left:10px" type="submit">STOCK IN</button>
                                
                                </div>
                            </form>
                        </div>

            <!-- #END# Input -->
            </div>
            </div>
            </div>
     </section>

</asp:Content>
