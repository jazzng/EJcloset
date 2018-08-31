<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminregistercashier.aspx.cs" Inherits="ejcloset.adminregistercashier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="content">
        <div class="container-fluid">
            <!-- Title -->
            <div class="block-header">
                <h1>REGISTER CASHIER</h1>
            </div>
            <!-- Basic Validation -->
            <div class="row clearfix">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="card">
                        <div class="header">
                            <h2>Please Fill In Cashier's Information</h2>

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
                            <form id="form_validation" method="POST">
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="text" class="form-control" name="user_id" required>
                                        <label class="form-label">User ID</label>
                                    </div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="text" class="form-control" name="user_fullname" required="">
                                        <label class="form-label">Full Name</label>
                                    </div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="text" class="form-control" name="user_phone" required="">
                                        <label class="form-label">Phone Number</label>
                                    </div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <textarea name="user_address" cols="30" rows="5" class="form-control no-resize" required=""></textarea>
                                        <label class="form-label">Address</label>
                                    </div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="email" class="form-control" name="email">
                                        <label class="form-label">E-mail</label>
                                    </div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="password" class="form-control" name="password" required>
                                        <label class="form-label">Password</label>
                                    </div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="password" class="form-control" name="password" required>
                                        <label class="form-label">Re-type Password</label>
                                    </div>
                                </div>
                                <div style="text-align:right">
                                    <button class="btn btn-warning waves-effect"  type="reset"> CLEAR </button>
                                <button class="btn btn-primary waves-effect" style="margin-left:10px" type="submit">REGISTER</button>
                                
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <!-- #END# Basic Validation -->

        </div>
    </section>



</asp:Content>
