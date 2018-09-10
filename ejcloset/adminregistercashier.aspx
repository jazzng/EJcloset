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
                                        <input type="text" class="form-control" runat="server" id="txt_user_id" name="user_id" required>
                                        <label class="form-label">User ID</label>
                                    </div>
                                    <div class="help-info">Create user id for login</div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="text" class="form-control" runat="server" id="txt_user_fullname" name="user_fullname" required="">
                                        <label class="form-label">Full Name</label>
                                    </div>
                                    <div class="help-info">Enter cashier's full name</div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="text" class="form-control" runat="server" id="txt_user_phone" name="user_phone" required="">
                                        <label class="form-label">Phone Number</label>
                                    </div>
                                    <div class="help-info">Enter cashier's phone number</div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <textarea name="user_address" id="txt_user_address" runat="server" cols="30" rows="5" class="form-control no-resize" required=""></textarea>
                                        <label class="form-label">Address</label>
                                    </div>
                                    <div class="help-info">Enter cashier's address</div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="email" class="form-control" runat="server" id="txt_user_email" name="user_email">
                                        <label class="form-label">E-mail</label>
                                    </div>
                                    <div class="help-info">Enter cashier's e-mail (Optional)</div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="password" class="form-control" runat="server" id="txt_user_password" name="user_password" required>
                                        <label class="form-label">Password</label>
                                    </div>
                                    <div class="help-info">Create password for login</div>
                                </div>
                                <div class="form-group form-float">
                                    <div class="form-line">
                                        <input type="password" class="form-control" runat="server" id="txt_user_password2" name="user_password2" required>
                                        <label class="form-label">Re-type Password</label>
                                    </div>
                                    <div class="help-info">Re-type password for login</div>
                                </div>
                                <div style="text-align:right; padding-top:30px">
                                    <button class="btn btn-warning waves-effect"  type="reset" id="btn_clear"> CLEAR </button>
                                <asp:button class="btn btn-primary waves-effect" style="margin-left:10px" type="submit" id="btn_register" OnClick="btn_register_click" runat="server" text="REGISTER"/>
                                
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
