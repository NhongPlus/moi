<template>
  <div>
    <div class="section-7">
      <div class="container">
        <div class="row">
            <div class="inner-head">
              <router-link to="/"><img src="../assets/image/logohang.png" alt=""></router-link>
              <h1>Đăng Nhập</h1>
            </div>
          </div>
        <div class="row">
          <div class="col-xl-6 offset-xl-3 col-lg-8 offset-lg-2">
            <div class="inner-khung">
              <div class="inner-title">
                <h1>Log In</h1>
              </div>
              <div class="inner-login">
                <form action="" class="form" @submit.prevent="handleSubmit">
                  <div class="input-field">
                    <input
                      required=""
                      autocomplete="off"
                      type="email"
                      name="email"
                      id="email"
                      placeholder="Email"
                      v-model="formData.email"
                    />
                  </div>
                  <div class="input-field">
                    <input
                      required=""
                      autocomplete="off"
                      type="password"
                      name="text"
                      id="password"
                      placeholder="Password"
                      v-model="formData.password"
                    />
                  </div>
                </form>
                <div class="button" @click="handleButtonClick">Submit</div>
                <p>Bạn Chưa Có Tài Khoản <router-link to="/signup">Đăng Kí</router-link></p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default{
  data() {
    return {
      formData: {
        email: '',
        password: '',
      },
    };
  },
  methods: {
    handleButtonClick() {
      if(this.formData.email === 'user' && this.formData.password === 'user' ){ 
        this.$router.push('/');
      }
      else{
        alert("Tên tài khoản hoặc mật khẩu sai");
      }
    },
  },
};
</script>
