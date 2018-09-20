<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminpaymenthistory.aspx.cs" Inherits="ejcloset.adminpaymenthistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">
        <div class="container-fluid">
            <!-- Title -->
            <div class="block-header">
                <h1>PAYMENT HISTORY</h1>
            </div>
            <!-- Example Tab -->
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="card">                      
                        <div class="body">
                            <!-- Nav tabs -->
                            <ul class="nav nav-tabs tab-nav-right" role="tablist">
                                <li role="presentation" class="active"><a href="#all" data-toggle="tab" runat="server" id="all">ALL</a></li>
                                <li role="presentation"><a href="#cash" data-toggle="tab">CASH</a></li>
                                <li role="presentation"><a href="#online" data-toggle="tab">ONLINE</a></li>
                                <li role="presentation"><a href="#creditcard" data-toggle="tab">CREDIT CARD</a></li>
                            </ul>


                            <!-- Tab panes -->
                            <div id="LoadPayment" class="tab-content">                                   
                                                        
                                <asp:PlaceHolder ID="LoadAll" runat="server"></asp:PlaceHolder>
                                <asp:PlaceHolder ID="LoadCash" runat="server"></asp:PlaceHolder>                          
                                <asp:PlaceHolder ID="LoadOnline" runat="server"></asp:PlaceHolder>
                                <asp:PlaceHolder ID="LoadCreditCard" runat="server"></asp:PlaceHolder>


                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- #END# Example Tab -->


        </div>
    </section>

</asp:Content>
