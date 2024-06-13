<template>
  <div>
    <nav-bar />
      <div class="container">
        <div class="row">
          <div class="is-medium">
              <router-link to="/">Home</router-link>
              <span>/</span>
              <router-link to="/">Sản Phẩm</router-link>
            </div>
          <div class="section-8">
            <div class="col-lg-5">
              <div class="inner-about">
                <h1>{{ selectedProduct.name }}</h1> 
                <img :src="selectedProduct.wooden" alt="Product Image">
              </div>
            </div>
            <div class="col-lg-1"></div>
            <div class="col-lg-6 col-sm-12 col-md-8">
              <div class="inner-des">
              <h1>Giá : {{ selectedProduct.price }} đ</h1>
              <ul>
                <li>Kích thước tùy chỉnh theo yêu cầu: 1m6/1m8/2m/2m2 × 2m…</li>
                <li>Chất liệu tuỳ chỉnh: Gỗ sồi, gỗ óc chó, gỗ hương…</li>
                <li>Tùy chỉnh:  Kích thước / chất liệu / Màu sắc</li>
                <li>Ưu điểm nổi bật: Giường gỗ ZA 808 của ZITO ghi điểm với thiết kế sang trọng, chân nối choãi thẩm mỹ, cùng những đường nét tinh tế, tôn lên vẻ đẹp đẳng cấp cho không gian, mang đến những phút giây thư giãn thoải mái cho người sử dụng.</li>
                <li>Bảo hành 2 năm</li>
                <li>Miễn phí vận chuyển nội thành, hỗ trợ 50% phí vận chuyển ngoại thành</li>
              </ul>
              <div class="inner-lienhe">
                <div class="button">Thêm Vào Giỏ</div>
                <div class="button">Yêu Cầu Tư Vấn</div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>

</template>

<script>
import NavBar from './NavBar.vue';
export default{
  components: { 
    NavBar, 
  },
  computed: {
    selectedProduct() {
        return this.$store.state.selectedProduct;
    }
  },
}
</script>

<style scoped>
.container{
  margin-top: 100px;
}
</style>