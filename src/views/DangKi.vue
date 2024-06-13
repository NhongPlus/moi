<template>
    <div>
      <div class="section-6">
        <div class="container">
          <div class="row">
            <div class="inner-head">
              <router-link to="/"><img src="../assets/image/logohang.png" alt=""></router-link>
              <h1>Đăng Kí</h1>
            </div>
          </div>
          <div class="row">
            <div class="col-xl-6 offset-xl-3 col-lg-8 offset-lg-2">               
                <div class="inner-khung">
                <div class="inner-title">
                  <h1>Create An Acount</h1>
                </div>
                <div class="inner-login">
                  <form action="" class="form">
                    <div class="input-field">
                      <input
                        required=""
                        autocomplete="off"
                        type="text"
                        name="text"
                        id="username"
                        placeholder="FullName"
                      />
                    </div>
                    <div class="input-field">
                      <input
                        required=""
                        autocomplete="off"
                        type="email"
                        name="email"
                        id="email"
                        placeholder="Email"
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
                      />
                    </div>
                  </form>
                  <div class="button">Submit</div>
                  <p class="mb-10">Bạn Đã Có Tài Khoản <router-link to="/login">Đăng Nhập</router-link></p> 
                </div>
                </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  
  </script>