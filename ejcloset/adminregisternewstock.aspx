<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminregisternewstock.aspx.cs" Inherits="ejcloset.adminregisternewstock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <section class="content">
        <div class="container-fluid">
            <!-- Title -->
            <div class="block-header">
                <h1>REGISTER NEW STOCK</h1>
            </div>

            <!-- Input -->
            <div class="row clearfix">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="card">
                        <div class="header">
                            <h2>Please Fill In New Stock Details</h2>

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
                                <label for="item_code">Item Code</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="item_code" class="form-control" placeholder="Enter item's barcode">
                                    </div>
                                </div>
                                <label for="item_title">Title</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="item_title" class="form-control" placeholder="Enter name of the item">
                                    </div>
                                </div>
                                <label for="item_price">Price</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="text" id="item_price" class="form-control" placeholder="Enter price of the item">
                                    </div>
                                </div>
                                

                        <label for="item_category">Category</label>
  
                            <div class="row clearfix">
                                <div class="col-sm-6">
                                    <select class="form-control" id="item_category">
                                        <option value="">-- Please select --</option>
                                        <option value="10">Category A</option>
                                        <option value="20">Category B</option>
                                    </select>
                                </div>
                            </div>

                               

                                <label for="item_supplier">Supplier</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        
                                        <input type="text" id="item_supplier" class="form-control" placeholder="Enter supplier's name of the item (Optional)">
                                    </div>
                                </div>
                                <label for="item_quantity">Quantity</label>
                                <div class="form-group">
                                    <div class="form-line">
                                        <input type="number" id="item_quantity" class="form-control">
                                    </div>
                                </div>

                                <div style="text-align:right">
                                    <button class="btn btn-warning waves-effect"  type="reset"> CLEAR </button>
                                <button class="btn btn-primary waves-effect" style="margin-left:10px" type="submit">REGISTER ITEM</button>
                                
                                </div>
                            </form>
                        </div>

            <!-- #END# Input -->
            </div>
            </div>
            </div>
     </section>


</asp:Content>
