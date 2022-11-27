<script>
	let login = '';
	let pwd = '';
</script>

<main>
  <slot>
    <!-- elementy strony -->
    <section>
        <div class="panel">
          <form>
            <label for="username">Nazwa użytkownika:</label>
            <input
              type="text"
              placeholder="Podaj nazwę użytkownika"
              id="username"
              required
              bind:value={login}
            />
            <label for="password">Hasło:</label>
            <input
              type="password"
              placeholder="Podaj hasło"
              id="password"
              required
              bind:value={pwd}
            />
            <div class="lower">
              <input type="submit" value="Loguj!" />
            </div>
          </form>
        </div>
    </section>
  </slot>
</main>

<style>
section {
		display: flex;
		flex-direction: column;
		justify-content: center;
		align-items: center;
		flex: 0.6;
	}

	.panel {
		width: 75%;
		margin: 0 auto;
		padding: 15px 0 0;
		background: #fff;
		border: 1px solid silver;
	}
	form {
		margin: 0;
	}

	label {
		display: block;
		width: 50%;
		padding: 10px 10px;
		margin: 0 20%;
		text-align: left;
		color: #696969;
		font-size: 16px;
		text-shadow: 0 0 1px silver;
	}

	#username,
	#password {
		display: block;
		width: 50%;
		margin: 0 20%;
		padding: 10px 5px;
		border: 1px solid silver;
		outline: 5px solid #ebebeb;
		font-size: 22px;
	}

	#username:focus,
	#password:focus {
		outline: 5px solid #e5f2f8;
	}

	.lower {
		background: #ecf2f5;
		width: 96%;
		padding: 1% 2%;
		margin-top: 20px;
	}

	input[type="submit"] {
		width: 20%;
		padding: 15px 13px;
		border: 1px solid #005f85;
		color: white;
		text-shadow: 0 0 1px black;
		background: #007acc;
		position: relative;
		left: 40%;
    cursor: pointer;
	}
</style>

