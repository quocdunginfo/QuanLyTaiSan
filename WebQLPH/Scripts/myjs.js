﻿function Duyet(id,trangthai) {
    document.getElementById("HiddenFieldID").value = id;
    document.getElementById("DropDownListTrangThai").value = trangthai;
    var ghichu = "GhiChu" + id;
    ghichu = document.getElementById(ghichu).innerHTML;
    document.getElementById("TextBoxGhiChu").value = ghichu;
    return false;
}
function KiemTraTruocKhiLuu() {
    var TextBoxGhiChu = document.getElementById("TextBoxGhiChu").value;
    if (TextBoxGhiChu == "") {
        alert("Ghi chú không được rỗng");
        document.getElementById("TextBoxGhiChu").focus();
        return false;
    }
    return true;
}