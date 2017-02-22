<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<style type="text/css">
    .img-style1 {
        width: 22px;
        height: 22px;
    }
    .star{
        display:inline-block;
    }
</style>

<script type="text/javascript">
    function display(index) {
        if (index == 0) {
            document.getElementById("star0").innerHTML = "<img onclick='display(0)' class='img-style1' src='../Images/star_full.png' />";
        } else if (index == 1) {
            document.getElementById("star0").innerHTML = "<img onclick='display(0)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star1").innerHTML = "<img onclick='display(1)' class='img-style1' src='../Images/star_full.png' />";
        } else if (index == 2) {
            document.getElementById("star0").innerHTML = "<img onclick='display(0)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star1").innerHTML = "<img onclick='display(1)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star2").innerHTML = "<img onclick='display(2)' class='img-style1' src='../Images/star_full.png' />";
        } else if (index == 3) {
            document.getElementById("star0").innerHTML = "<img onclick='display(0)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star1").innerHTML = "<img onclick='display(1)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star2").innerHTML = "<img onclick='display(2)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star3").innerHTML = "<img onclick='display(3)' class='img-style1' src='../Images/star_full.png' />";
        } else if (index == 4) {
            document.getElementById("star0").innerHTML = "<img onclick='display(0)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star1").innerHTML = "<img onclick='display(1)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star2").innerHTML = "<img onclick='display(2)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star3").innerHTML = "<img onclick='display(3)' class='img-style1' src='../Images/star_full.png' />";
            document.getElementById("star4").innerHTML = "<img onclick='display(4)' class='img-style1' src='../Images/star_full.png' />";
        }
    }
</script>
<div class="rating">
    <div class="star" id="star0"><img onclick="display(0)" class="img-style1" src="../Images/star_empty.png" /></div>
    <div class="star" id="star1"><img onclick="display(1)" class="img-style1" src="../Images/star_empty.png" /></div>
    <div class="star" id="star2"><img onclick="display(2)" class="img-style1" src="../Images/star_empty.png" /></div>
    <div class="star" id="star3"><img onclick="display(3)" class="img-style1" src="../Images/star_empty.png" /></div>
    <div class="star" id="star4"><img onclick="display(4)" class="img-style1" src="../Images/star_empty.png" /></div>
</div>
